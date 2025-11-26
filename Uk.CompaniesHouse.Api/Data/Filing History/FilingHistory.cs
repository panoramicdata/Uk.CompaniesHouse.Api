using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Filing_History;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Filing history details
/// </summary>
[DataContract]
public class FilingHistory
{
	/// <summary>
	/// Annotations for the filing
	/// </summary>
	[DataMember(Name = "annotations")]
	public List<Annotations>? Annotations { get; set; }

	/// <summary>
	/// Any filings associated with the current item
	/// </summary>
	[DataMember(Name = "associated_filings")]
	public List<AssociatedFilings>? AssociatedFilings { get; set; }

	/// <summary>
	/// The category of the document filed.
	/// </summary>
	[DataMember(Name = "category")]
	public string Category { get; set; } = string.Empty;

	/// <summary>
	/// The date the filing was processed.
	/// </summary>
	[DataMember(Name = "date")]
	public string Date { get; set; } = string.Empty;

	/// <summary>
	/// A description of the filing.
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Links to other resources associated with this filing history item.
	/// </summary>
	[DataMember(Name = "links")]
	public FilingHistoryLinks? Links { get; set; }

	/// <summary>
	/// The type of filing.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Number of pages within the PDF document
	/// </summary>
	[DataMember(Name = "pages")]
	public int? Pages { get; set; }

	/// <summary>
	/// The barcode of the document.
	/// </summary>
	[DataMember(Name = "barcode")]
	public string Barcode { get; set; } = string.Empty;

	/// <summary>
	/// The transaction ID of the filing.
	/// </summary>
	[DataMember(Name = "transaction_id")]
	public string TransactionId { get; set; } = string.Empty;

	/// <summary>
	/// If true, indicates this is a paper filing.
	/// </summary>
	[DataMember(Name = "paper_filed")]
	public bool? Etag { get; set; }

	/// <summary>
	/// Resolutions for the filing
	/// </summary>
	[DataMember(Name = "resolutions")]
	public List<Resolutions>? Resolutions { get; set; }

	/// <summary>
	/// The sub-category of the document filed.
	/// </summary>
	[DataMember(Name = "subcategory")]
	public string? Subcategory { get; set; }
}
