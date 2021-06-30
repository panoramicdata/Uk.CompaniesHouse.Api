using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Filing history links
	/// </summary>
	[DataContract]
	public class FilingHistoryLinks
	{
		/// <summary>
		/// Self
		/// </summary>
		[DataMember(Name = "self")]
		public string? Self { get; set; }

		/// <summary>
		/// Document metadata
		/// </summary>
		[DataMember(Name = "document_metadata")]
		public string? DocumentMetadata { get; set; }
	}
}
