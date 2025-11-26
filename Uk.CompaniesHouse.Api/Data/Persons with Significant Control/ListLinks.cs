using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// Links
/// </summary>
[DataContract]
public class ListLinks
{
	/// <summary>
	/// The URL of the persons with significant control statements list resource.
	/// </summary>
	[DataMember(Name = "persons_with_significant_control_list")]
	public string? PersonsWithSignificantControlList { get; set; }

	/// <summary>
	/// The URL of the resource.
	/// </summary>
	[DataMember(Name = "self")]
	public string Self { get; set; } = string.Empty;
}
