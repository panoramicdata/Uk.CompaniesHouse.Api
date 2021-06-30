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
		public bool? ContainsFixedCharge { get; set; }

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
		public bool? ContainsNegativePledge { get; set; }

		/// <summary>
		/// Chargor acting as bare trustee?
		/// </summary>
		[DataMember(Name = "chargor_acting_as_bare_trustee")]
		public bool? ChargorActingAsBareTrustee { get; set; }

		/// <summary>
		/// Contains floating charge?
		/// </summary>
		[DataMember(Name = "contains_floating_charge")]
		public bool? ContainsFloatingCharge { get; set; }

		/// <summary>
		/// Floating charge covers all?
		/// </summary>
		[DataMember(Name = "floating_charge_covers_all")]
		public bool? FloatingChargeCoversAll { get; set; }
	}
}
