using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// Transactions that have been filed for the charge.
/// </summary>
[DataContract]
public class InsolvencyCases
{
	/// <summary>
	/// The number of this insolvency case
	/// </summary>
	[DataMember(Name = "case_number")]
	public int? CaseNumber { get; set; }

	/// <summary>
	/// The resources related to this insolvency case
	/// </summary>
	[DataMember(Name = "links")]
	public List<InsolvencyCasesLinks>? Links { get; set; }

	/// <summary>
	/// The id of the insolvency filing
	/// </summary>
	[DataMember(Name = "transaction_id")]
	public int? TransactionID { get; set; }
}
