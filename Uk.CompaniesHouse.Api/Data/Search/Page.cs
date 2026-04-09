using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search;

/// <summary>
/// Represents a paged search response.
/// </summary>
/// <typeparam name="T">The item type returned in the page.</typeparam>
[DataContract]
public class Page<T>
{
	/// <summary>
	/// Gets or sets the items returned for the current page.
	/// </summary>
	[DataMember(Name = "items")]
	public List<T> Items { get; set; } = [];

	/// <summary>
	/// Gets or sets the zero-based index of the first returned item.
	/// </summary>
	[DataMember(Name = "start_index")]
	public int StartIndex { get; set; }

	/// <summary>
	/// Gets or sets the maximum number of items returned in the page.
	/// </summary>
	[DataMember(Name = "items_per_page")]
	public int ItemsPerPage { get; set; }

	/// <summary>
	/// Gets or sets the API kind value for the result set.
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = null!;

	/// <summary>
	/// Gets or sets the one-based page number when the API provides it.
	/// </summary>
	[DataMember(Name = "page_number")]
	public int PageNumber { get; set; }

	/// <summary>
	/// Gets or sets the total number of matching results.
	/// </summary>
	[DataMember(Name = "total_results")]
	public int TotalResults { get; set; }
}