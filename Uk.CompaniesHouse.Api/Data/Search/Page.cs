using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	[DataContract]
	public class Page<T>
	{
		[DataMember(Name = "items")]
		public List<T> Items { get; set; } = new();

		[DataMember(Name = "start_index")]
		public int StartIndex { get; set; }

		[DataMember(Name = "items_per_page")]
		public int ItemsPerPage { get; set; }

		[DataMember(Name = "kind")]
		public string Kind { get; set; } = null!;

		[DataMember(Name = "page_number")]
		public int PageNumber { get; set; }

		[DataMember(Name = "total_results")]
		public int TotalResults { get; set; }
	}
}