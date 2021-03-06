using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class CompanySearchTests : TestBase
	{
		public CompanySearchTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Search
				.GetCompanyInfoByNameAsync("Panoramic Data Limited", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.TotalResults.Should().NotBe(0);

			var item = result.Items[0];

			item.Title.Should().Be("PANORAMIC DATA LIMITED");
			item.CompanyType.Should().Be("ltd");
			item.CompanyNumber.Should().Be("06982102");
			item.CompanyStatus.Should().Be("active");

			var address = item.Address;
			address.Should().NotBeNull();
			address.Premises.Should().Be("46");
			address.AddressLine1.Should().Be("Heywood Avenue");
			address.Locality.Should().Be("Maidenhead");
			address.PostalCode.Should().Be("SL6 3JA");
		}

		[Fact]

		public async void Search_InvalidQuery_Fails()
		{
			var result = await Client
				.Search
				.GetCompanyInfoByNameAsync("xyzzzzzzzzzzzzz", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.TotalResults.Should().Be(0);
		}

		[Fact]
		public async void GetCompanyInfo_Succeeds()
		{
			var result = await Client
				.Company
				.GetByIdAsync("06982102", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
		}
	}
}
