using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers;

/// <summary>
/// List of registered company persons with significant control.
/// </summary>
[DataContract]
public class PersonsWithSignificantControl
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
	public PersonsWithSignificantControlLinks? Links { get; set; }

	/// <summary>
	/// The register type.
	/// </summary>
	[DataMember(Name = "register_type")]
	public string? RegisterType { get; set; }
}
