using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers;

/// <summary>
/// Officer links
/// </summary>
[DataContract]
public class OfficerLinks
{
	/// <summary>
	/// Links to other officer resources associated with this officer list item.
	/// </summary>
	[DataMember(Name = "officer")]
	public OfficerAppoint Officer { get; set; } = new();

	/// <summary>
	/// Link to this individual company officer appointment resource.
	/// </summary>
	[DataMember(Name = "self")]
	public string Self { get; set; } = string.Empty;
}
