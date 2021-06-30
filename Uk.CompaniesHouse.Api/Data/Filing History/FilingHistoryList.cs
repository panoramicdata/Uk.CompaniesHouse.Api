using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Company;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Filing history list
	/// </summary>
	[DataContract]
	public class FilingHistoryList
	{
		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Filing history status
		/// </summary>
		[DataMember(Name = "filing_history_status")]
		public string? FilingHistoryStatus { get; set; }

		/// <summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<FilingHistory> Items { get; set; } = new();

		/// <summary>
		/// Items per page
		/// </summary>
		[DataMember(Name = "items_per_page")]
		public int ItemsPerPage { get; set; } = 0;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Start index
		/// </summary>
		[DataMember(Name = "start_index")]
		public int StartIndex { get; set; } = 0;

		/// <summary>
		/// Total count
		/// </summary>
		[DataMember(Name = "total_count")]
		public int TotalCount { get; set; } = 0;
	}
}
