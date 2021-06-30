using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Annotations
	/// </summary>
	[DataContract]
	public class Annotations
	{
		/// <summary>
		/// Annotation
		/// </summary>
		[DataMember(Name = "annotation")]
		public string? Annotation { get; set; }

		/// <summary>
		/// Date
		/// </summary>
		[DataMember(Name = "date")]
		public string Date { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;
	}
}
