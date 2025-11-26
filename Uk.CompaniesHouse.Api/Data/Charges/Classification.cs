using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// Classification information
/// </summary>
[DataContract]
public class Classification
{
	///<summary>
	/// Details of the charge classification
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	///<summary>
	/// The type of charge classication.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
