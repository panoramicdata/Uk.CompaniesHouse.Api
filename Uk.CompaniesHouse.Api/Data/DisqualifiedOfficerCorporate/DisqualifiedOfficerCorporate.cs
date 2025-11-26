using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerCorporate;

/// <summary>
/// Disqualified corporate officer
/// </summary>
[DataContract]
public class DisqualifiedOfficerCorporate
{
	/// <summary>
	/// The registration number of the disqualified officer.
	/// </summary>
	[DataMember(Name = "company_number")]
	public string? CompanyNumber { get; set; }

	/// <summary>
	/// The country in which the disqualified officer was registered.
	/// </summary>
	[DataMember(Name = "country_of_registration")]
	public string? CountryOfRegistration { get; set; }

	/// <summary>
	/// The officer's disqualifications.
	/// </summary>
	[DataMember(Name = "disqualifications")]
	public List<Disqualifications> Disqualifications { get; set; } = new();

	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// Kind
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// Links to other resources associated with this officer disqualification resource.
	/// </summary>
	[DataMember(Name = "links")]
	public Links Links { get; set; } = new();

	/// <summary>
	/// The name of the disqualified officer.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Permissions that the disqualified officer has to act outside of their disqualification.
	/// </summary>
	[DataMember(Name = "permissions_to_act")]
	public List<PermissionsToAct>? PermissionsToAct { get; set; }
}
