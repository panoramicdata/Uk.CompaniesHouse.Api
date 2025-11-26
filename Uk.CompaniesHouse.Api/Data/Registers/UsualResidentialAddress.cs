using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers;

/// <summary>
/// List of register addresses.
/// </summary>
[DataContract]
public class UsualResidentialAddress
{
	/// <summary>
	/// Items
	/// </summary>
	[DataMember(Name = "items")]
	public List<RegistersItems> Items { get; set; } = new();

	/// <summary>
	/// A set of URLs related to the resource.
	/// </summary>
	[DataMember(Name = "links")]
	public UsualResidentialAddressLinks? Links { get; set; }

	/// <summary>
	/// The register type.
	/// </summary>
	[DataMember(Name = "register_type")]
	public string RegisterType { get; set; } = string.Empty;
}
