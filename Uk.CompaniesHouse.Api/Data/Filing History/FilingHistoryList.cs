using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Company;

namespace Uk.CompaniesHouse.Api.Data.Filing_History;

/// <summary>
/// Filing history list
/// </summary>
[DataContract]
public class FilingHistoryList
{
	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// The status of this filing history.
	/// </summary>
	[DataMember(Name = "filing_history_status")]
	public string? FilingHistoryStatus { get; set; }

	/// <summary>
	/// The filing history items.
	/// </summary>
	[DataMember(Name = "items")]
	public List<FilingHistory> Items { get; set; } = [];

	/// <summary>
	/// The number of filing history items returned per page.
	/// </summary>
	[DataMember(Name = "items_per_page")]
	public int ItemsPerPage { get; set; }

	/// <summary>
	/// Indicates this resource is a filing history.
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// The index into the entire result set that this result page starts.
	/// </summary>
	[DataMember(Name = "start_index")]
	public int StartIndex { get; set; }

	/// <summary>
	/// The total number of filing history items for this company.
	/// </summary>
	[DataMember(Name = "total_count")]
	public int TotalCount { get; set; }
}
