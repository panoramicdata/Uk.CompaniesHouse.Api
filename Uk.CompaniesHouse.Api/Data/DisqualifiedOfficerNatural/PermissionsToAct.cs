using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural;

/// <summary>
/// Permissions to act
/// </summary>
[DataContract]
public class PermissionsToAct
{
	/// <summary>
	/// The companies for which the disqualified officer has permission to act.
	/// </summary>
	[DataMember(Name = "company_names")]
	public List<string>? CompanyNames { get; set; }

	/// <summary>
	/// The name of the court that granted the permission to act.
	/// </summary>
	[DataMember(Name = "court_name")]
	public string? CourtName { get; set; }

	/// <summary>
	/// The date that the permission ends.
	/// </summary>
	[DataMember(Name = "expires_on")]
	public string ExpiresOn { get; set; } = string.Empty;

	/// <summary>
	/// The date that the permission starts.
	/// </summary>
	[DataMember(Name = "granted_on")]
	public string GrantedOn { get; set; } = string.Empty;
}
