using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// PscExemptAsTradingOnRegulatedMarket
	/// </summary>
	[DataContract]
	public class PscExemptAsTradingOnRegulatedMarket
	{
		///<summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<Items> Items { get; set; } = new();

		///<summary>
		/// Exemption type
		/// </summary>
		[DataMember(Name = "exemption_type")]
		public string ExemptionType { get; set; } = string.Empty;
	}
}
