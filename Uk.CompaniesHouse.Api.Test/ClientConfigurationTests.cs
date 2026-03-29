using AwesomeAssertions;
using System;
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
}
