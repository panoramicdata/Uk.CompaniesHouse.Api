using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class RegisteredOfficeAddressTests : TestBase
	{
		public RegisteredOfficeAddressTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		private readonly string ExampleCompanyID = "06982102";

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetRegisteredAddressAsync(ExampleCompanyID, default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();

			result.Locality.Should().Be("Maidenhead");
			result.AddressLine1.Should().Be("46 Heywood Avenue");
		}
	}
}