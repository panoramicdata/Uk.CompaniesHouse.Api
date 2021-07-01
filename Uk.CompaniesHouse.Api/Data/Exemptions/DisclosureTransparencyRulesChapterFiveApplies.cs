using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// If present the company has been or is exempt from keeping a PSC register, because it is a DTR issuer and the shares are admitted to trading on a regulated market.
	/// </summary>
	[DataContract]
	public class DisclosureTransparencyRulesChapterFiveApplies
	{
		///<summary>
		/// The exemption type.
		/// </summary>
		[DataMember(Name = "exemption_type")]
		public string ExemptionType { get; set; } = string.Empty;

		///<summary>
		/// List of exemption periods.
		/// </summary>
		[DataMember(Name = "items")]
		public List<Items> Items { get; set; } = new();
	}
}
