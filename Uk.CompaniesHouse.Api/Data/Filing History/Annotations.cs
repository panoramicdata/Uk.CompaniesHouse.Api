using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Annotations for the filing
	/// </summary>
	[DataContract]
	public class Annotations
	{
		/// <summary>
		/// The annotation text.
		/// </summary>
		[DataMember(Name = "annotation")]
		public string? Annotation { get; set; }

		/// <summary>
		/// The date the annotation was added.
		/// </summary>
		[DataMember(Name = "date")]
		public string Date { get; set; } = string.Empty;

		/// <summary>
		/// A description of the annotation.
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;
	}
}
