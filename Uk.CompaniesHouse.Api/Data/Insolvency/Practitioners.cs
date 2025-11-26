using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Insolvency;

/// <summary>
/// The practitioners for the case.
/// </summary>
[DataContract]
public class Practitioners
{
	///<summary>
	/// The practitioners' address.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();

	///<summary>
	/// The name of the practitioner.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	///<summary>
	/// The type of role.
	/// </summary>
	[DataMember(Name = "role")]
	public string? Role { get; set; }

	///<summary>
	/// The date the practitioner ceased to act for the case.
	/// </summary>
	[DataMember(Name = "ceased_to_act_on")]
	public string? CeasedToActOn { get; set; }

	///<summary>
	/// The date the practitioner was appointed on.
	/// </summary>
	[DataMember(Name = "appointed_on")]
	public string? AppointedOn { get; set; }
}
