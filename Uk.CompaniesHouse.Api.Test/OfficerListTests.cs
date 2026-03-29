using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class OfficerListTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "06982102";

	[Fact]
	public async Task GetOfficerList_ValidCompany_Succeeds()
	{
       if (IsSandbox)
		{
			return;
		}

		var result = await Client
			.Company
			.GetOfficerListByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();
		result.Items.Should().NotBeNullOrEmpty();
		result.TotalResults.Should().BePositive();

		var officer = result.Items[0];
		officer.Name.Should().NotBeNullOrEmpty();
		officer.OfficerRole.Should().NotBeNullOrEmpty();
	}
}
