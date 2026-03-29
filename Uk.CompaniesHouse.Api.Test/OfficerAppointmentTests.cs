using AwesomeAssertions;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class OfficerAppointmentTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "06982102";

	[Fact]
	public async Task GetOfficerByAppointment_ValidCompany_Succeeds()
	{
        if (IsSandbox)
		{
			return;
		}

		// First get the officer list to find a valid appointment ID
		var officerList = await Client
			.Company
			.GetOfficerListByIdAsync(ExampleCompanyID, CancellationToken);

		officerList.Should().NotBeNull();
		officerList.Items.Should().NotBeNullOrEmpty();

		// Extract the appointment ID from the self link
		var selfLink = officerList.Items[0].Links.Self;
		selfLink.Should().NotBeNullOrEmpty();

		var appointmentId = selfLink.Split('/').Last();

		var result = await Client
			.Company
			.GetOfficerInformationByAppointmentAsync(
				ExampleCompanyID,
				appointmentId,
				CancellationToken);

		result.Should().NotBeNull();
		result.Name.Should().NotBeNullOrEmpty();
		result.OfficerRole.Should().NotBeNullOrEmpty();
	}
}
