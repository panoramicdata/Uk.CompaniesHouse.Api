using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class FilingHistorySearchTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "06982102";

	[Fact]
	public async Task Search_ValidQuery_Succeeds()
	{
		var result = await Client
			.Company
			.GetFilingHistoryListByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();
		result.Items.Should().NotBeNullOrEmpty();

		var item = result.Items[0];

		item.Category.Should().NotBeNullOrEmpty();
		item.Pages.Should().BePositive();
		item.Barcode.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task Search_InvalidQuery_Fails()
	{
		var result = await Client
			.Company
			.GetFilingHistoryListByIdAsync("xyzzzzzzzzzzzzz", CancellationToken);

		result.Should().NotBeNull();
	}
}