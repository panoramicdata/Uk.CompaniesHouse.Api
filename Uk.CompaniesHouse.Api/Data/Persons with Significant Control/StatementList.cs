using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Statement list
	/// </summary>
	[DataContract]
	public class StatementList
	{
		/// <summary>
		/// Active count
		/// </summary>
		[DataMember(Name = "active_count")]
		public int ActiveCount { get; set; } = 0;

		/// <summary>
		/// Ceased count
		/// </summary>
		[DataMember(Name = "ceased_count")]
		public int CeasedCount { get; set; } = 0;

		/// <summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public Statement Items { get; set; } = new();

		/// <summary>
		/// Items per page
		/// </summary>
		[DataMember(Name = "items_per_page")]
		public int ItemsPerPage { get; set; } = 0;

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public ListLinks Links { get; set; } = new();

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
