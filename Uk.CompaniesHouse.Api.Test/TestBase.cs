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
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json", optional: false)
			.Build();

		var apiKey = configuration["AppSettings:ApiKey"]
			?? throw new InvalidDataException("API key not found in configuration.");

		Client = new CompaniesHouseClient(new CompaniesHouseClientOptions
		{
			ApiKey = apiKey
		},
			Log
		);
	}
}
