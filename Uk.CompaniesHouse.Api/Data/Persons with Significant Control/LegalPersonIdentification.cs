using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// Identification
/// </summary>
[DataContract]
public class LegalPersonIdentification
{
	/// <summary>
	/// The legal authority supervising the legal person with significant control.
	/// </summary>
	[DataMember(Name = "legal_authority")]
	public string LegalAuthority { get; set; } = string.Empty;

	/// <summary>
	/// The legal form of the legal person with significant control as defined by its country of registration.
	/// </summary>
	[DataMember(Name = "legal_form")]
	public string LegalForm { get; set; } = string.Empty;
}
