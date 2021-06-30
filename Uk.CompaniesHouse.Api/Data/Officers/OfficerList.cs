using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Officers
{
	/// <summary>
	/// List of officers
	/// </summary>
	[DataContract]
	public class OfficerList
	{
		/// <summary>
		/// Active count
		/// </summary>
		[DataMember(Name = "active_count")]
		public int ActiveCount { get; set; } = 0;

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<Officer> Items { get; set; } = new();

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
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// Resigned count
		/// </summary>
		[DataMember(Name = "resigned_count")]
		public int ResignedCount { get; set; } = 0;

		/// <summary>
		/// Start index
		/// </summary>
		[DataMember(Name = "start_index")]
		public int StartIndex { get; set; } = 0;

		/// <summary>
		/// Total results
		/// </summary>
		[DataMember(Name = "total_results")]
		public int TotalResults { get; set; } = 0;
	}
}
