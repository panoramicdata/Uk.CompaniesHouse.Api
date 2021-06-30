using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Resolutions
	/// </summary>
	[DataContract]
	public class Resolutions
	{
		/// <summary>
		/// Category
		/// </summary>
		[DataMember(Name = "category")]
		public string Category { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Document ID
		/// </summary>
		[DataMember(Name = "document_id")]
		public string? DocumentID { get; set; }

		/// <summary>
		/// Receive date
		/// </summary>
		[DataMember(Name = "receive_date")]
		public string ReceiveDate { get; set; } = string.Empty;

		/// <summary>
		/// Subcategory
		/// </summary>
		[DataMember(Name = "subcategory")]
		public string Subcategory { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
