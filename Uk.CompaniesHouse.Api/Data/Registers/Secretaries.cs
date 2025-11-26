using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers;

/// <summary>
/// List of registered company secretaries.
/// </summary>
[DataContract]
public class Secretaries
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
	public SecretariesLinks? Links { get; set; }

	/// <summary>
	/// The register type.
	/// </summary>
	[DataMember(Name = "register_type")]
	public string RegisterType { get; set; } = string.Empty;
}
