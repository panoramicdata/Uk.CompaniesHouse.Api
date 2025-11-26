using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.UkEstablishments;

/// <summary>
/// UK Establishments
/// </summary>
[DataContract]
public class UkEstablishments
{
	///<summary>
	/// UK Establishment Resources related to this company.
	/// </summary>
	[DataMember(Name = "links")]
	public Links? Links { get; set; }

	///<summary>
	/// List of UK Establishment companies.
	/// </summary>
	[DataMember(Name = "items")]
	public List<Items> Items { get; set; } = [];

	///<summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	///<summary>
	/// Kind
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;
}
