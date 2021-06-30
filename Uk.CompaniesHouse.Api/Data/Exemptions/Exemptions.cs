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
		public PscExemptAsTradingOnRegulatedMarket? PscExemptAsTradingOnUkRegulatedMarket { get; set; }

		///<summary>
		/// Psc exempt as shares admitted on market
		/// </summary>
		[DataMember(Name = "psc_exempt_as_shares_admitted_on_market")]
		public PscExemptAsSharesAdmittedOnMarket? PscExemptAsSharesAdmittedOnMarket { get; set; }

		///<summary>
		/// DisclosureTransparencyRulesChapterFiveApplies
		/// </summary>
		[DataMember(Name = "disclosure_transparency_rules_chapter_five_applies")]
		public DisclosureTransparencyRulesChapterFiveApplies? DisclosureTransparencyRulesChapterFiveApplies { get; set; }
	}
}
