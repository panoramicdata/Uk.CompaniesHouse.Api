using AwesomeAssertions;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class FilingHistoryItemTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "06982102";

	[Fact]
	public async Task GetFilingHistoryItem_ValidTransaction_Succeeds()
	{
     if (IsSandbox)
		{
			return;
		}

		// First get the filing history list to find a valid transaction ID
		var list = await Client
			.Company
			.GetFilingHistoryListByIdAsync(ExampleCompanyID, CancellationToken);

		list.Should().NotBeNull();
		list.Items.Should().NotBeNullOrEmpty();

		var transactionId = list.Items[0].TransactionId;
		transactionId.Should().NotBeNullOrEmpty();

		var result = await Client
			.Company
         .GetFilingHistoryByIdAsync(ExampleCompanyID, transactionId, CancellationToken);

		result.Should().NotBeNull();
		result.Category.Should().NotBeNullOrEmpty();
	}
}
