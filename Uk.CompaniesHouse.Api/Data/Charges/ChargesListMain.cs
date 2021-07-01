using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// The ETag of the resource.
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
		/// List of charges
		/// </summary>
		[DataMember(Name = "items")]
		public List<Charges> Items { get; set; } = new();

		/// <summary>
		/// Number of satisfied charges
		/// </summary>
		[DataMember(Name = "part_satisfied_count")]
		public int? PartSatisfiedCount { get; set; }

		/// <summary>
		/// Number of satisfied charges
		/// </summary>
		[DataMember(Name = "satisfied_count")]
		public int? SatisfiedCount { get; set; }

		/// <summary>
		/// Total number of charges returned by the API (filtering applies).
		/// </summary>
		[DataMember(Name = "total_count")]
		public int? TotalCount { get; set; }

		/// <summary>
		/// Number of satisfied charges
		/// </summary>
		[DataMember(Name = "unfiletered_count")]
		public int? UnfilteredCount { get; set; }
	}
}
