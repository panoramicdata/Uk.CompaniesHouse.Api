using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class UkEstablishmentsTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	// FC company with UK establishments
	private readonly string ExampleCompanyID = "FC004404";

	[Fact]
	public async Task GetUkEstablishments_ValidCompany_Succeeds()
	{
       if (IsSandbox)
		{
			return;
		}

		var result = await Client
			.Company
			.GetUkEstablishmentsByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();
		result.Items.Should().NotBeNullOrEmpty();
	}
}
