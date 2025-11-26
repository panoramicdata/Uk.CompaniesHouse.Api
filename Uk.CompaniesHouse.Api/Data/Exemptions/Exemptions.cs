using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions;

/// <summary>
/// Company exemptions information.
/// </summary>
[DataContract]
public class Exemptions
{
	///<summary>
	/// If present the company has been or is exempt from keeping a PSC register, as it has voting shares admitted to trading on a regulated market other than the UK.
	/// </summary>
	[DataMember(Name = "psc_exempt_as_trading_on_uk_regulated_market")]
	public PscExemptAsTradingOnRegulatedMarket? PscExemptAsTradingOnUkRegulatedMarket { get; set; }

	///<summary>
	/// If present the company has been or is exempt from keeping a PSC register, as it has voting shares admitted to trading on a market listed in the Register of People with Significant Control Regulations 2016.
	/// </summary>
	[DataMember(Name = "psc_exempt_as_shares_admitted_on_market")]
	public PscExemptAsSharesAdmittedOnMarket? PscExemptAsSharesAdmittedOnMarket { get; set; }

	///<summary>
	/// If present the company has been or is exempt from keeping a PSC register, because it is a DTR issuer and the shares are admitted to trading on a regulated market.
	/// </summary>
	[DataMember(Name = "disclosure_transparency_rules_chapter_five_applies")]
	public DisclosureTransparencyRulesChapterFiveApplies? DisclosureTransparencyRulesChapterFiveApplies { get; set; }
}
