using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Officers;

/// <summary>
/// List of officers
/// </summary>
[DataContract]
public class OfficerList
{
	/// <summary>
	/// The number of active officers in this result set.
	/// </summary>
	[DataMember(Name = "active_count")]
	public int ActiveCount { get; set; } = 0;

	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// The list of officers.
	/// </summary>
	[DataMember(Name = "items")]
	public List<Officer> Items { get; set; } = new();

	/// <summary>
	/// The number of officers to return per page.
	/// </summary>
	[DataMember(Name = "items_per_page")]
	public int ItemsPerPage { get; set; } = 0;

	/// <summary>
	/// Kind
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// Links to other resources associated with this officer list resource.
	/// </summary>
	[DataMember(Name = "type")]
	public Links Links { get; set; } = new();

	/// <summary>
	/// The number of resigned officers in this result set.
	/// </summary>
	[DataMember(Name = "resigned_count")]
	public int ResignedCount { get; set; } = 0;

	/// <summary>
	/// The offset into the entire result set that this page starts.
	/// </summary>
	[DataMember(Name = "start_index")]
	public int StartIndex { get; set; } = 0;

	/// <summary>
	/// The total number of officers in this result set.
	/// </summary>
	[DataMember(Name = "total_results")]
	public int TotalResults { get; set; } = 0;
}
