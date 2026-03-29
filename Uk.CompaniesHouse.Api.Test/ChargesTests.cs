using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class ChargesTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	// A company known to have charges
	private readonly string ExampleCompanyID = "00229606";

	[Fact]
	public async Task GetChargesList_ValidCompany_Succeeds()
	{
       if (IsSandbox)
		{
			return;
		}

		var result = await Client
			.Company
			.GetChargesListByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();
		result.Items.Should().NotBeNullOrEmpty();
		result.TotalCount.Should().BePositive();
	}

	[Fact]
	public async Task GetChargesById_ValidCharge_Succeeds()
	{
     if (IsSandbox)
		{
			return;
		}

		// First get the charges list to find a valid charge ID
		var list = await Client
			.Company
			.GetChargesListByIdAsync(ExampleCompanyID, CancellationToken);

		list.Should().NotBeNull();
		list.Items.Should().NotBeNullOrEmpty();

		var chargeId = list.Items[0].ChargeCode;
		chargeId.Should().NotBeNullOrEmpty();

		var result = await Client
			.Company
            .GetChargesByIdAsync(ExampleCompanyID, chargeId, CancellationToken);

		result.Should().NotBeNull();
		result.Status.Should().NotBeNullOrEmpty();
	}
}
