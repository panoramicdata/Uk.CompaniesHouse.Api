using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// If present the company has been or is exempt from keeping a PSC register, as it has voting shares admitted to trading on a regulated market other than the UK.
	/// </summary>
	[DataContract]
	public class PscExemptAsTradingOnRegulatedMarket
	{
		///<summary>
		/// The exemption type.
		/// </summary>
		[DataMember(Name = "items")]
		public List<Items> Items { get; set; } = new();

		///<summary>
		/// List of dates
		/// </summary>
		[DataMember(Name = "exemption_type")]
		public string ExemptionType { get; set; } = string.Empty;
	}
}
