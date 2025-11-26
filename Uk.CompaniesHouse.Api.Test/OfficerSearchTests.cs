using AwesomeAssertions;
using System.Linq;
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
		result.Items.Should().NotBeNullOrEmpty();

		// Find an item that actually contains "BOND" in the title
		var bondItem = result.Items.FirstOrDefault(i => i.Title?.Contains("BOND") == true);
		bondItem.Should().NotBeNull("at least one result should contain BOND");

		bondItem!.Title.Should().NotBeNullOrEmpty();

		var address = bondItem.Address;
		address.Should().NotBeNull();
		address.PostalCode.Should().NotBeNullOrEmpty();
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