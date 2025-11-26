using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// Information about alterations for Scottish companies
/// </summary>
[DataContract]
public class ScottishAlterations
{
	/// <summary>
	/// Description
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// The charge has alterations to order
	/// </summary>
	[DataMember(Name = "has_alterations_to_order")]
	public bool? HasAlterationsToOrder { get; set; }

	/// <summary>
	/// The charge has alterations to prohibitions
	/// </summary>
	[DataMember(Name = "has_alterations_to_prohibitions")]
	public bool? HasAlterationsToProhibitions { get; set; }

	/// <summary>
	/// The charge has provisions restricting the creation of further charges
	/// </summary>
	[DataMember(Name = "has_alterations_to_provisions")]
	public bool? HasAlterationsToProvisions { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}
