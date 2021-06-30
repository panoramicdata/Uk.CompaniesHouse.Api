using System.Collections.Generic;
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
		/// Annotations
		/// </summary>
		[DataMember(Name = "annotations")]
		public List<Annotations>? Annotations { get; set; }

		/// <summary>
		/// Associated filings
		/// </summary>
		[DataMember(Name = "associated_filings")]
		public List<AssociatedFilings>? AssociatedFilings { get; set; }

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
		public FilingHistoryLinks? Links { get; set; }

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Pages
		/// </summary>
		[DataMember(Name = "pages")]
		public int? Pages { get; set; }

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

		/// <summary>
		/// Paper filed?
		/// </summary>
		[DataMember(Name = "paper_filed")]
		public bool? Etag { get; set; }

		/// <summary>
		/// Resolutions
		/// </summary>
		[DataMember(Name = "resolutions")]
		public List<Resolutions>? Resolutions { get; set; }

		/// <summary>
		/// Subcategory
		/// </summary>
		[DataMember(Name = "subcategory")]
		public string? Subcategory { get; set; }
	}
}
