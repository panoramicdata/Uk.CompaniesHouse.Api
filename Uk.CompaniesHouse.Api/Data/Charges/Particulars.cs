using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Particulars
	/// </summary>
	[DataContract]
	public class Particulars
	{
		///<summary>
		/// Contains fixed charge?
		/// </summary>
		[DataMember(Name = "contains_fixed_charge")]
		public bool ContainsFixedCharge { get; set; } = false;

		///<summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		///<summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		///<summary>
		/// Contains negative pledge?
		/// </summary>
		[DataMember(Name = "contains_negative_pledge")]
		public bool ContainsNegativePledge { get; set; } = false;
	}
}
