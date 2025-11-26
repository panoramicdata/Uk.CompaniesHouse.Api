using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History;

/// <summary>
/// Links to other resources associated with this filing history item.
/// </summary>
[DataContract]
public class FilingHistoryLinks
{
	/// <summary>
	/// Link to this filing history item.
	/// </summary>
	[DataMember(Name = "self")]
	public string? Self { get; set; }

	/// <summary>
	/// Link to the document metadata associated with this filing history item.
	/// </summary>
	[DataMember(Name = "document_metadata")]
	public string? DocumentMetadata { get; set; }
}
