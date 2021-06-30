using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Charges list
	/// </summary>
	[DataContract]
	public class ChargesListMain
	{
		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<Charges> Items { get; set; } = new();

		/// <summary>
		/// Part satisfied count
		/// </summary>
		[DataMember(Name = "part_satisfied_count")]
		public int? PartSatisfiedCount { get; set; }

		/// <summary>
		/// Satisfied count
		/// </summary>
		[DataMember(Name = "satisfied_count")]
		public int? SatisfiedCount { get; set; }

		/// <summary>
		/// Total count
		/// </summary>
		[DataMember(Name = "total_count")]
		public int? TotalCount { get; set; }

		/// <summary>
		/// Unfiltered count
		/// </summary>
		[DataMember(Name = "unfiletered_count")]
		public int? UnfilteredCount { get; set; }
	}
}
