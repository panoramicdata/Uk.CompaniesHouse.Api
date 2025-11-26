using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// A set of URLs related to the resource, including self.
/// </summary>
[DataContract]
public class StatementLinks
{
	/// <summary>
	/// The URL of the person with significant control linked to this statement.
	/// </summary>
	[DataMember(Name = "person_with_significant_control")]
	public string? PersonWithSignificantControl { get; set; }

	/// <summary>
	/// The URL of the resource.
	/// </summary>
	[DataMember(Name = "self")]
	public string Self { get; set; } = string.Empty;
}
