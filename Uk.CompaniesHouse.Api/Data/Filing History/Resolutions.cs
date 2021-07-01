using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Resolutions for the filing
	/// </summary>
	[DataContract]
	public class Resolutions
	{
		/// <summary>
		/// The category of the resolution filed.
		/// </summary>
		[DataMember(Name = "category")]
		public string Category { get; set; } = string.Empty;

		/// <summary>
		/// A description of the associated filing.
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// The document id of the resolution.
		/// </summary>
		[DataMember(Name = "document_id")]
		public string? DocumentID { get; set; }

		/// <summary>
		/// The date the resolution was processed.
		/// </summary>
		[DataMember(Name = "receive_date")]
		public string ReceiveDate { get; set; } = string.Empty;

		/// <summary>
		/// The sub-category of the document filed.
		/// </summary>
		[DataMember(Name = "subcategory")]
		public string Subcategory { get; set; } = string.Empty;

		/// <summary>
		/// The type of the associated filing.
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
