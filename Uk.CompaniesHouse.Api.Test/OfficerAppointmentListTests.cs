using AwesomeAssertions;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class OfficerAppointmentListTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "06982102";

	[Fact]
	public async Task GetOfficerAppointments_ValidOfficer_Succeeds()
	{
        if (IsSandbox)
		{
			return;
		}

		// First get the officer list to find a valid officer ID
		var officerList = await Client
			.Company
			.GetOfficerListByIdAsync(ExampleCompanyID, CancellationToken);

		officerList.Should().NotBeNull();
		officerList.Items.Should().NotBeNullOrEmpty();

		// Extract the officer ID from the appointments link
		var appointmentsLink = officerList.Items[0].Links.Officer.Appointments;
		appointmentsLink.Should().NotBeNullOrEmpty();

		// The link is like /officers/{officer_id}/appointments - extract the officer ID
		var parts = appointmentsLink.Split('/');
		var officerIdIndex = System.Array.IndexOf(parts, "officers") + 1;
		var officerId = parts[officerIdIndex];

		var result = await Client
			.Company
			.GetOfficerAppointmentsAsync(officerId, CancellationToken);

		result.Should().NotBeNull();
		result.Items.Should().NotBeNullOrEmpty();
		result.TotalResults.Should().BePositive();
		result.Name.Should().NotBeNullOrEmpty();

		var appointment = result.Items[0];
		appointment.OfficerRole.Should().NotBeNullOrEmpty();
	}
}
