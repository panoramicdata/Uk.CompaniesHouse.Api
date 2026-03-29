using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers;

/// <summary>
/// List of officer appointments
/// </summary>
[DataContract]
public class OfficerAppointmentList
{
	/// <summary>
	/// The date of birth of the officer.
	/// </summary>
	[DataMember(Name = "date_of_birth")]
	public Common.DateOfBirth? DateOfBirth { get; set; }

	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string? Etag { get; set; }

	/// <summary>
	/// Indicates whether the officer is a corporate body.
	/// </summary>
	[DataMember(Name = "is_corporate_officer")]
	public bool IsCorporateOfficer { get; set; }

	/// <summary>
	/// The list of officer appointments.
	/// </summary>
	[DataMember(Name = "items")]
	public List<OfficerAppointmentItem> Items { get; set; } = [];

	/// <summary>
	/// The number of items to return per page.
	/// </summary>
	[DataMember(Name = "items_per_page")]
	public int ItemsPerPage { get; set; }

	/// <summary>
	/// Kind
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// Links to other resources associated with this officer appointment list.
	/// </summary>
	[DataMember(Name = "links")]
	public Common.Links Links { get; set; } = new();

	/// <summary>
	/// The name of the officer.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The index of the first result returned.
	/// </summary>
	[DataMember(Name = "start_index")]
	public int StartIndex { get; set; }

	/// <summary>
	/// The total number of appointments in this result set.
	/// </summary>
	[DataMember(Name = "total_results")]
	public int TotalResults { get; set; }
}
