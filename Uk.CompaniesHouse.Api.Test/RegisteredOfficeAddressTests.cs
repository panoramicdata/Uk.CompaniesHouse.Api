using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class RegisteredOfficeAddressTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "06982102";

	[Fact]
	public async Task Search_ValidQuery_Succeeds()
	{
		var result = await Client
			.Company
			.GetRegisteredAddressAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();

		result.Locality.Should().Be("Maidenhead");
		result.AddressLine1.Should().Be("46 Heywood Avenue");
	}
}