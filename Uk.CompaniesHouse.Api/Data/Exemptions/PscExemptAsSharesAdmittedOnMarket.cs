using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// If present the company has been or is exempt from keeping a PSC register, as it has voting shares admitted to trading on a market listed in the Register of People with Significant Control Regulations 2016.
	/// </summary>
	[DataContract]
	public class PscExemptAsSharesAdmittedOnMarket
	{
		///<summary>
		/// The exemption type.
		/// </summary>
		[DataMember(Name = "exemption_type")]
		public string ExemptionType { get; set; } = string.Empty;

		///<summary>
		/// List of dates
		/// </summary>
		[DataMember(Name = "items")]
		public List<Items> Items { get; set; } = new();
	}
}
