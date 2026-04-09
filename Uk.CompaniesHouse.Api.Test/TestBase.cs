using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

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
					Assert.Skip("Skipping integration tests: API key not found in user secrets. See usersecrets.example.json for the expected format.");
				}

				options.ApiKey = apiKey;
				break;
			case CompaniesHouseAuthenticationMode.OAuthBearerToken:
				var accessToken = configuration["AppSettings:AccessToken"];
				if (string.IsNullOrWhiteSpace(accessToken))
				{
					Assert.Skip("Skipping integration tests: Access token not found in user secrets.");
				}

				options.AccessToken = accessToken;
				break;
		}

		Client = new CompaniesHouseClient(options, Log);
	}
}
