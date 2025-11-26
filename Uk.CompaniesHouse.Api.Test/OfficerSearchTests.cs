using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class OfficerSearchTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	[Fact]
	public async Task Search_ValidQuery_Succeeds()
	{
		var result = await Client
			.Search
			.GetOfficerInfoByNameAsync("David Niel Bond", CancellationToken);

		result.Should().NotBeNull();
		result.TotalResults.Should().NotBe(0);

		var item = result.Items[0];

		item.Title.Should().Be("David Niel Marshall BOND");

		var address = item.Address;
		address.AddressLine1.Should().Be("Heywood Avenue");
		address.Country.Should().Be("England");
		address.PostalCode.Should().Be("SL6 3JA");
		address.Region.Should().Be("Berkshire");

		var dob = item.DateOfBirth;
		dob.Month.Should().Be("2");
		dob.Year.Should().Be("1975");
	}

	[Fact]
	public async Task Search_InvalidQuery_Fails()
	{
		var result = await Client
			.Search
			.GetOfficerInfoByNameAsync("xyzzzzzzzzzzzzz", CancellationToken);

		result.Should().NotBeNull();
		result.TotalResults.Should().Be(0);
	}
}