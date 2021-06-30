using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Insolvency cases
	/// </summary>
	[DataContract]
	public class InsolvencyCases
	{
		/// <summary>
		/// Case number
		/// </summary>
		[DataMember(Name = "case_number")]
		public int? CaseNumber { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public List<InsolvencyCasesLinks>? Links { get; set; }

		/// <summary>
		/// Transaction ID
		/// </summary>
		[DataMember(Name = "transaction_id")]
		public int? TransactionID { get; set; }
	}
}
