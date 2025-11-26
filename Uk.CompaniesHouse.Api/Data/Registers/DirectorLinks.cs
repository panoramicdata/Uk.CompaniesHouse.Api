using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers;

/// <summary>
/// A set of URLs related to the resource.
/// </summary>
[DataContract]
public class DirectorLinks
{
	/// <summary>
	/// The URL for the resource.
	/// </summary>
	[DataMember(Name = "directors_register")]
	public string? DirectorsRegister { get; set; }
}
