using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class CompanySearchTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task Search_ValidQuery_Succeeds()
	{
		var result = await Client
			.Search
			.GetCompanyInfoByNameAsync("Panoramic Data Limited", CancellationToken);

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
	public async Task Search_InvalidQuery_Fails()
	{
		var result = await Client
			.Search
			.GetCompanyInfoByNameAsync("xyzzzzzzzzzzzzz", CancellationToken);

		result.Should().NotBeNull();
		result.TotalResults.Should().Be(0);
	}

	[Fact]
	public async Task GetCompanyInfo_Succeeds()
	{
		var result = await Client
			.Company
			.GetByIdAsync("06982102", CancellationToken);

		result.Should().NotBeNull();
	}
}
