using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Filing_History;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Filing history details
	/// </summary>
	[DataContract]
	public class FilingHistory
	{
		/// <summary>
		/// Action date
		/// </summary>
		[DataMember(Name = "action_date")]
		public string ActionDate { get; set; } = string.Empty;

		/// <summary>
		/// Category
		/// </summary>
		[DataMember(Name = "category")]
		public string Category { get; set; } = string.Empty;

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

		/// <summary>
		/// Description values
		/// </summary>
		[DataMember(Name = "description_values")]
		public DescriptionValues DescriptionValues { get; set; } = new();

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public FilingHistoryLinks Links { get; set; } = new();

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Pages
		/// </summary>
		[DataMember(Name = "pages")]
		public int Pages { get; set; } = 0;

		/// <summary>
		/// Barcode
		/// </summary>
		[DataMember(Name = "barcode")]
		public string Barcode { get; set; } = string.Empty;

		/// <summary>
		/// Transaction ID
		/// </summary>
		[DataMember(Name = "transaction_id")]
		public string TransactionId { get; set; } = string.Empty;
	}
}
