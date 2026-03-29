using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class RegistersTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	// This company has elected to keep information on the public register
	private readonly string ExampleCompanyID = "00502851";

	[Fact]
	public async Task GetRegisters_ValidCompany_Succeeds()
	{
       if (IsSandbox)
		{
			return;
		}

		var result = await Client
			.Company
			.GetRegisterInfoByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();
		result.Kind.Should().Be("registers");
	}
}
