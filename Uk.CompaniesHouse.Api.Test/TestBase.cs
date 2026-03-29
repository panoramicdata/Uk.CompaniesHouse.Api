using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
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
                options.ApiKey = apiKey
					?? throw new InvalidDataException("API key not found in user secrets. See usersecrets.example.json for the expected format.");
				break;
			case CompaniesHouseAuthenticationMode.OAuthBearerToken:
				options.AccessToken = configuration["AppSettings:AccessToken"]
					?? throw new InvalidDataException("Access token not found in user secrets.");
				break;
		}

		Client = new CompaniesHouseClient(options, Log);
	}
}
