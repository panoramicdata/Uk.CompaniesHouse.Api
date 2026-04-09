using AwesomeAssertions;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Uk.CompaniesHouse.Api.Data.Company;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class ClientConfigurationTests
{
	[Fact]
	public void GetBaseUrl_Live_ReturnsProductionUrl()
	{
		CompaniesHouseClient.GetBaseUrl(ApiEnvironment.Live)
			.Should().Be("https://api.company-information.service.gov.uk/");
	}

	[Fact]
	public void GetBaseUrl_Sandbox_ReturnsSandboxUrl()
	{
		CompaniesHouseClient.GetBaseUrl(ApiEnvironment.Sandbox)
			.Should().Be("https://api-sandbox.company-information.service.gov.uk/");
	}

	[Fact]
	public void GetBaseUrl_UnknownEnvironment_Throws()
	{
		var action = () => CompaniesHouseClient.GetBaseUrl((ApiEnvironment)int.MaxValue);

		action.Should().Throw<ArgumentOutOfRangeException>();
	}

	[Fact]
	public void CompaniesHouseClientOptions_DefaultsAndSetters_WorkAsExpected()
	{
		var options = new CompaniesHouseClientOptions();

		options.ApiKey.Should().Be(string.Empty);
		options.AccessToken.Should().Be(string.Empty);
		options.AuthenticationMode.Should().Be(CompaniesHouseAuthenticationMode.ApiKey);
		options.UserAgent.Should().Be("Uk.CompaniesHouse.Api");
		options.Environment.Should().Be(ApiEnvironment.Live);

		options.ApiKey = "key";
		options.AccessToken = "token";
		options.AuthenticationMode = CompaniesHouseAuthenticationMode.OAuthBearerToken;
		options.UserAgent = "custom-agent";
		options.Environment = ApiEnvironment.Sandbox;

		options.ApiKey.Should().Be("key");
		options.AccessToken.Should().Be("token");
		options.AuthenticationMode.Should().Be(CompaniesHouseAuthenticationMode.OAuthBearerToken);
		options.UserAgent.Should().Be("custom-agent");
		options.Environment.Should().Be(ApiEnvironment.Sandbox);

		var other = new CompaniesHouseClientOptions
		{
			ApiKey = "key",
			AccessToken = "token",
			AuthenticationMode = CompaniesHouseAuthenticationMode.OAuthBearerToken,
			UserAgent = "custom-agent",
			Environment = ApiEnvironment.Sandbox
		};

		options.Should().Be(other);
		options.GetHashCode().Should().Be(other.GetHashCode());
		options.ToString().Should().Contain(nameof(CompaniesHouseClientOptions.ApiKey));
	}

	[Fact]
	public void GetAuthorizationHeaderValue_ApiKey_ReturnsBasicHeader()
	{
		var result = AuthenticatedHttpClientHandler.GetAuthorizationHeaderValue(new CompaniesHouseClientOptions
		{
			ApiKey = "my_api_key",
			AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey
		});

		result.Should().Be("Basic bXlfYXBpX2tleTo=");
	}

	[Fact]
	public void GetAuthorizationHeaderValue_BearerToken_ReturnsBearerHeader()
	{
		var result = AuthenticatedHttpClientHandler.GetAuthorizationHeaderValue(new CompaniesHouseClientOptions
		{
			AccessToken = "my_access_token",
			AuthenticationMode = CompaniesHouseAuthenticationMode.OAuthBearerToken
		});

		result.Should().Be("Bearer my_access_token");
	}

	[Fact]
	public void GetAuthorizationHeaderValue_MissingApiKey_Throws()
	{
		var action = () => AuthenticatedHttpClientHandler.GetAuthorizationHeaderValue(new CompaniesHouseClientOptions
		{
			AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey
		});

		action.Should().Throw<InvalidOperationException>();
	}

	[Fact]
	public void GetAuthorizationHeaderValue_MissingAccessToken_Throws()
	{
		var action = () => AuthenticatedHttpClientHandler.GetAuthorizationHeaderValue(new CompaniesHouseClientOptions
		{
			AuthenticationMode = CompaniesHouseAuthenticationMode.OAuthBearerToken
		});

		action.Should().Throw<InvalidOperationException>();
	}

	[Fact]
	public void GetAuthorizationHeaderValue_UnknownAuthenticationMode_Throws()
	{
		var action = () => AuthenticatedHttpClientHandler.GetAuthorizationHeaderValue(new CompaniesHouseClientOptions
		{
			AuthenticationMode = (CompaniesHouseAuthenticationMode)int.MaxValue
		});

		action.Should().Throw<ArgumentOutOfRangeException>();
	}

	[Fact]
	public void SystemTextJsonSerializer_UsesDataMemberNames_WhenDeserializing()
	{
		var createOptionsMethod = typeof(CompaniesHouseClient)
			.GetMethod("CreateJsonSerializerOptions", BindingFlags.NonPublic | BindingFlags.Static);

		createOptionsMethod.Should().NotBeNull();

		var options = createOptionsMethod!
			.Invoke(null, null)
			.Should().BeOfType<JsonSerializerOptions>()
			.Subject;

		const string json = """
		{
			"date_of_creation": "2001-02-03",
			"company_number": "12345678",
			"company_name": "Acme Ltd"
		}
		""";

		var company = JsonSerializer.Deserialize<Company>(json, options);

		company.Should().NotBeNull();
		company!.CreationDate.Should().Be("2001-02-03");
		company.CompanyNumber.Should().Be("12345678");
		company.CompanyName.Should().Be("Acme Ltd");
	}

	[Fact]
	public void SystemTextJsonSerializer_UsesNamingPolicy_WhenDataMemberAbsent()
	{
		var createOptionsMethod = typeof(CompaniesHouseClient)
			.GetMethod("CreateJsonSerializerOptions", BindingFlags.NonPublic | BindingFlags.Static);

		createOptionsMethod.Should().NotBeNull();

		var options = createOptionsMethod!
			.Invoke(null, null)
			.Should().BeOfType<JsonSerializerOptions>()
			.Subject;

		const string json = """
		{
			"sample_value": "ok"
		}
		""";

		var model = JsonSerializer.Deserialize<NoDataMemberModel>(json, options);

		model.Should().NotBeNull();
		model!.SampleValue.Should().Be("ok");
	}

	[Fact]
	public async Task SendAsync_AddsHeaders_WhenMissing()
	{
		var options = new CompaniesHouseClientOptions
		{
			ApiKey = "my_api_key",
			AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey,
			UserAgent = "uk-companieshouse-tests"
		};

		using var handler = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		using var client = new HttpClient(handler);
		using var request = new HttpRequestMessage(HttpMethod.Get, "http://127.0.0.1:1/");

		await Record.ExceptionAsync(() => client.SendAsync(request, CancellationToken.None));

		request.Headers.TryGetValues(AuthenticatedHttpClientHandler.UserAgentHeader, out var userAgents).Should().BeTrue();
		userAgents!.Should().Contain("uk-companieshouse-tests");
		request.Headers.Authorization.Should().NotBeNull();
		request.Headers.Authorization!.Scheme.Should().Be("Basic");
	}

	[Fact]
	public async Task SendAsync_DoesNotOverwriteExistingHeaders()
	{
		var options = new CompaniesHouseClientOptions
		{
			ApiKey = "my_api_key",
			AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey,
			UserAgent = "uk-companieshouse-tests"
		};

		using var handler = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		using var client = new HttpClient(handler);
		using var request = new HttpRequestMessage(HttpMethod.Get, "http://127.0.0.1:1/");
		request.Headers.Add(AuthenticatedHttpClientHandler.UserAgentHeader, "existing-agent");
		request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "existing-token");

		await Record.ExceptionAsync(() => client.SendAsync(request, CancellationToken.None));

		request.Headers.TryGetValues(AuthenticatedHttpClientHandler.UserAgentHeader, out var userAgents).Should().BeTrue();
		userAgents!.Should().ContainSingle(x => x == "existing-agent");
		request.Headers.Authorization.Should().NotBeNull();
		request.Headers.Authorization!.Scheme.Should().Be("Bearer");
		request.Headers.Authorization.Parameter.Should().Be("existing-token");
	}

	[Fact]
	public async Task SendAsync_LogsRequestBody_WhenContentPresent()
	{
		var options = new CompaniesHouseClientOptions
		{
			ApiKey = "my_api_key",
			AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey,
			UserAgent = "uk-companieshouse-tests"
		};

		using var handler = new AuthenticatedHttpClientHandler(options, NullLogger.Instance);
		using var client = new HttpClient(handler);
		using var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:1/")
		{
			Content = new StringContent("{\"message\":\"hello\"}")
		};

		await Record.ExceptionAsync(() => client.SendAsync(request, CancellationToken.None));

		request.Content.Should().NotBeNull();
	}

	private sealed class NoDataMemberModel
	{
		public string SampleValue { get; set; } = string.Empty;
	}
}
