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
		var psc = exemps.PscExemptAsTradingOnUkRegulatedMarket;
		var pscItems = psc.Items[0];
		var dis = exemps.DisclosureTransparencyRulesChapterFiveApplies;
		var disItems = dis.Items[0];

		result.Etag.Should().Be("deb030fda295b063e7d89dbde4b5a49bd0e52af4");
		pscItems.ExemptFrom.Should().Be("2018-05-08");
		psc.ExemptionType.Should().Be("psc-exempt-as-trading-on-uk-regulated-market");

		disItems.ExemptTo.Should().Be("2021-04-19");

		result.Kind.Should().Be("exemptions");
	}
}