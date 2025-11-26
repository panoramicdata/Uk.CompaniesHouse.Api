using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// The resources related to this filing
/// </summary>
[DataContract]
public class TransactionsLinks
{
	///<summary>
	///	Link to the charge filing data
	/// </summary>
	[DataMember(Name = "filing")]
	public string? Filing { get; set; }

	/// <summary>
	/// Link to the insolvency case related to this filing
	/// </summary>
	[DataMember(Name = "insolvency_case")]
	public string? InsolvencyCase { get; set; }
}
