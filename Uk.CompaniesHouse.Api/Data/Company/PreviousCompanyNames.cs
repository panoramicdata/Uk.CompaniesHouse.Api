using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// The previous names of this company.
/// </summary>
[DataContract]
public class PreviousCompanyNames
{
	/// <summary>
	/// The string on which the company name ceased.
	/// </summary>
	[DataMember(Name = "ceased_on")]
	public string CeasedOn { get; set; } = string.Empty;

	/// <summary>
	/// The string from which the company name was effective.
	/// </summary>
	[DataMember(Name = "effective_from")]
	public string EffectiveFrom { get; set; } = string.Empty;

	/// <summary>
	/// The previous company name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
