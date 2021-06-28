using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// DisclosureTransparencyRulesChapterFiveApplies
	/// </summary>
	[DataContract]
	public class DisclosureTransparencyRulesChapterFiveApplies
	{
		///<summary>
		/// Exemption type
		/// </summary>
		[DataMember(Name = "exemption_type")]
		public string ExemptionType { get; set; } = string.Empty;

		///<summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<Items> Items { get; set; } = new();
	}
}
