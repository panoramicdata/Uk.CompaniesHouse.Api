using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class ExemptionsTests : TestBase
	{
		public ExemptionsTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetExemptionsByIdAsync("00502851", default)
				.ConfigureAwait(false);

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
}