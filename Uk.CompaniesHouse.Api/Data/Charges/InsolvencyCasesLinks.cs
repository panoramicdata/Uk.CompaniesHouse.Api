using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// The resources related to this insolvency case
/// </summary>
[DataContract]
public class InsolvencyCasesLinks
{
	/// <summary>
	/// Link to the insolvency case data
	/// </summary>
	[DataMember(Name = "case")]
	public string? Case { get; set; }
}
