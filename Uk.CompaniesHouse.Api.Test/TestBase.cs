using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

// Every derived suite calls the live Companies House API with an API key from user secrets, so
// the Integration category is set here once and inherited, and CI filters it out (OPS-157454).
[Trait("Category", "Integration")]
public abstract class TestBase
{
	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	protected ApiEnvironment CurrentEnvironment { get; }

	protected bool IsSandbox => CurrentEnvironment == ApiEnvironment.Sandbox;

	public ILogger Log { get; }

	public CompaniesHouseClient Client { get; }

	protected TestBase(ITestOutputHelper testOutputHelper)
	{
		Log = new XunitLogger<TestBase>(testOutputHelper, LogLevel.Debug);

		var configuration = new ConfigurationBuilder()
			.AddUserSecrets<TestBase>()
			.Build();

        var apiKey = configuration["AppSettings:ApiKey"];

		var options = new CompaniesHouseClientOptions
       {
			AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey
		};

		var authenticationMode = configuration["AppSettings:AuthenticationMode"];
		if (Enum.TryParse<CompaniesHouseAuthenticationMode>(authenticationMode, ignoreCase: true, out var parsedAuthenticationMode))
		{
			options.AuthenticationMode = parsedAuthenticationMode;
		}

		var environment = configuration["AppSettings:Environment"];
		if (Enum.TryParse<ApiEnvironment>(environment, ignoreCase: true, out var parsed))
		{
			options.Environment = parsed;
		}

		CurrentEnvironment = options.Environment;

		switch (options.AuthenticationMode)
		{
			case CompaniesHouseAuthenticationMode.ApiKey:
				if (string.IsNullOrWhiteSpace(apiKey))
				{
					throw new InvalidOperationException("Companies House API key not configured. Set AppSettings:ApiKey in user secrets (see usersecrets.example.json).");
				}

				options.ApiKey = apiKey;
				break;
			case CompaniesHouseAuthenticationMode.OAuthBearerToken:
				var accessToken = configuration["AppSettings:AccessToken"];
				if (string.IsNullOrWhiteSpace(accessToken))
				{
					throw new InvalidOperationException("Companies House access token not configured. Set AppSettings:AccessToken in user secrets (see usersecrets.example.json).");
				}

				options.AccessToken = accessToken;
				break;
		}

		Client = new CompaniesHouseClient(options, Log);
	}
}
