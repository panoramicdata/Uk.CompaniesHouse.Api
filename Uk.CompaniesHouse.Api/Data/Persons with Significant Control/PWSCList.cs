using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// List
/// </summary>
[DataContract]
public class PWSCList
{
	/// <summary>
	/// The number of active persons with significant control in this result set.
	/// </summary>
	[DataMember(Name = "active_count")]
	public int ActiveCount { get; set; } = 0;

	/// <summary>
	/// The number of ceased persons with significant control in this result set.
	/// </summary>
	[DataMember(Name = "ceased_count")]
	public int CeasedCount { get; set; } = 0;

	/// <summary>
	/// The list of persons with significant control.
	/// </summary>
	[DataMember(Name = "items")]
	public List<PWSCListItems> Items { get; set; } = new();

	/// <summary>
	/// The number of persons with significant control to return per page.
	/// </summary>
	[DataMember(Name = "items_per_page")]
	public int ItemsPerPage { get; set; } = 0;

	/// <summary>
	/// A set of URLs related to the resource, including self.
	/// </summary>
	[DataMember(Name = "links")]
	public ListLinks Links { get; set; } = new();

	/// <summary>
	/// The offset into the entire result set that this page starts.
	/// </summary>
	[DataMember(Name = "start_index")]
	public int StartIndex { get; set; } = 0;

	/// <summary>
	/// The total number of persons with significant control in this result set.
	/// </summary>
	[DataMember(Name = "total_results")]
	public int TotalResults { get; set; } = 0;
}
