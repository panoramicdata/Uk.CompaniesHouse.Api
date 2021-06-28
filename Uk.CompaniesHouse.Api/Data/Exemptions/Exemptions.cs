using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// Exemptions details
	/// </summary>
	[DataContract]
	public class Exemptions
	{
		///<summary>
		/// Psc exempt as trading on uk regulated market
		/// </summary>
		[DataMember(Name = "psc_exempt_as_trading_on_uk_regulated_market")]
		public PscExemptAsTradingOnUkRegulatedMarket PscExemptAsTradingOnUkRegulatedMarket { get; set; } = new();

		///<summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "disclosure_transparency_rules_chapter_five_applies")]
		public DisclosureTransparencyRulesChapterFiveApplies DisclosureTransparencyRulesChapterFiveApplies { get; set; } = new();
	}
}
