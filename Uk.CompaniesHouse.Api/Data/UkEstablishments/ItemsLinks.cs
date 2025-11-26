using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.UkEstablishments;

/// <summary>
/// Links
/// </summary>
[DataContract]
public class ItemsLinks
{
	/// <summary>
	/// Company
	/// </summary>
	[DataMember(Name = "company")]
	public string Company { get; set; } = string.Empty;
}
