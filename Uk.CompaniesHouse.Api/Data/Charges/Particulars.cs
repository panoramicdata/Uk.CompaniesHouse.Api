using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// Details of charge or undertaking
/// </summary>
[DataContract]
public class Particulars
{
	///<summary>
	/// The charge contains a fixed charge
	/// </summary>
	[DataMember(Name = "contains_fixed_charge")]
	public bool? ContainsFixedCharge { get; set; }

	///<summary>
	/// Details of charge particulars
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	///<summary>
	/// The type of charge particulars.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	///<summary>
	/// The charge contains a negative pledge
	/// </summary>
	[DataMember(Name = "contains_negative_pledge")]
	public bool? ContainsNegativePledge { get; set; }

	/// <summary>
	/// The chargor is acting as a bare trustee for the property
	/// </summary>
	[DataMember(Name = "chargor_acting_as_bare_trustee")]
	public bool? ChargorActingAsBareTrustee { get; set; }

	/// <summary>
	/// The charge contains a floating charge
	/// </summary>
	[DataMember(Name = "contains_floating_charge")]
	public bool? ContainsFloatingCharge { get; set; }

	/// <summary>
	/// The floating charge covers all the property or undertaking or the company
	/// </summary>
	[DataMember(Name = "floating_charge_covers_all")]
	public bool? FloatingChargeCoversAll { get; set; }
}
