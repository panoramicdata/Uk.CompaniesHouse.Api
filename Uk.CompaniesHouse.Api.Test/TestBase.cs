using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Threading;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public abstract class TestBase
{
	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	public ILogger Log { get; }

	public CompaniesHouseClient Client { get; }

	protected TestBase(ITestOutputHelper testOutputHelper)
	{
		Log = new XunitLogger<TestBase>(testOutputHelper, LogLevel.Debug);

		var configuration = new ConfigurationBuilder()
			.AddUserSecrets<TestBase>()
			.Build();

		var apiKey = configuration["AppSettings:ApiKey"]
			?? throw new InvalidDataException("API key not found in user secrets. See usersecrets.example.json for the expected format.");

		var options = new CompaniesHouseClientOptions
		{
			ApiKey = apiKey
		};

		var baseUrl = configuration["AppSettings:BaseUrl"];
		if (!string.IsNullOrWhiteSpace(baseUrl))
		{
			options.BaseUrl = baseUrl;
		}

		Client = new CompaniesHouseClient(options, Log);
	}
}
