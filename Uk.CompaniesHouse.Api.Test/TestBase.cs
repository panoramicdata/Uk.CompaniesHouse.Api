using Divergic.Logging.Xunit;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public abstract class TestBase
	{
		public ICacheLogger<TestBase> Log { get; }

		public CompaniesHouseClient Client { get; }

		protected TestBase(
			ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options)
		{
			Log = testOutputHelper.BuildLoggerFor<TestBase>(LogLevel.Debug);
			var optionsValue = options.Value;
			Client = new CompaniesHouseClient(new CompaniesHouseClientOptions
			{
				ApiKey = optionsValue.ApiKey
			},
				Log
			);
		}
	}
}
