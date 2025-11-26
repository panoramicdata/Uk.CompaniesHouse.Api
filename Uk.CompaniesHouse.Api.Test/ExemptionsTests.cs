using AwesomeAssertions;
using System.Threading.Tasks;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class ExemptionsTests(ITestOutputHelper testOutputHelper) : TestBase(testOutputHelper)
{
	private readonly string ExampleCompanyID = "00502851";

	[Fact]
	public async Task Search_ValidQuery_Succeeds()
	{
		var result = await Client
			.Company
			.GetExemptionsByIdAsync(ExampleCompanyID, CancellationToken);

		result.Should().NotBeNull();

		var exemps = result.Exemptions;
		exemps.Should().NotBeNull();
		
		var psc = exemps.PscExemptAsTradingOnUkRegulatedMarket;
		psc.Should().NotBeNull();
		
		var pscItems = psc.Items[0];
		pscItems.ExemptFrom.Should().Be("2018-05-08");
		psc.ExemptionType.Should().Be("psc-exempt-as-trading-on-uk-regulated-market");

		var dis = exemps.DisclosureTransparencyRulesChapterFiveApplies;
		dis.Should().NotBeNull();
		
		var disItems = dis.Items[0];
		disItems.ExemptFrom.Should().NotBeNullOrEmpty();

		result.Etag.Should().NotBeNullOrEmpty();
		result.Kind.Should().Be("exemptions");
	}
}