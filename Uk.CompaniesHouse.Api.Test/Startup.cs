using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Uk.CompaniesHouse.Api.Test
{
	public class Startup
	{
		public void ConfigureHost(IHostBuilder hostBuilder)
		{
			var currentDirectory = Directory.GetCurrentDirectory();
			var fileInfo = new FileInfo(Path.Combine(currentDirectory, "../../../appsettings.json"));
			hostBuilder
				.ConfigureHostConfiguration(builder =>
					builder.AddJsonFile(fileInfo.FullName));
		}

		public void ConfigureServices(
			IServiceCollection services,
			HostBuilderContext context)
		{
			var options = context.Configuration.GetSection("AppSettings");
			services
				.Configure<AppSettings>(options);
		}
	}
}
