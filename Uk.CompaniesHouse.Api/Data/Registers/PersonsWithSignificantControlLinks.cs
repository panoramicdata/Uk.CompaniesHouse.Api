using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers;

/// <summary>
/// A set of URLs related to the resource.
/// </summary>
[DataContract]
public class PersonsWithSignificantControlLinks
{
	/// <summary>
	/// The URL for the resource.
	/// </summary>
	[DataMember(Name = "persons_with_significant_control_register")]
	public string? PersonsWithSignificantControlRegister { get; set; }
}
