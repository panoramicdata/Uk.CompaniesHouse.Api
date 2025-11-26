using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class InsolvencyTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "00229606";

	[Fact]
	public async Task Search_ValidQuery_Succeeds()
	{
		var result = await Client
			.Company
			.GetInsolvencyByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();
		var caseOne = result.Cases[0];
		var Pract = caseOne.Practitioners[0];
		var Address = Pract.Address;
		var Dates = caseOne.Dates[0];

		Address.AddressLine1.Should().Be("15 Canada Square");
		Address.Locality.Should().Be("London");

		Pract.Name.Should().Be("William James Wright");

		caseOne.Type.Should().Be("corporate-voluntary-arrangement");

		Dates.Type.Should().Be("voluntary-arrangement-started-on");
	}
}