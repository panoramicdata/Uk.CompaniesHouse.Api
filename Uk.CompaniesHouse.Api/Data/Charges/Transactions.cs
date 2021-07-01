using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Transactions that have been filed for the charge.
	/// </summary>
	[DataContract]
	public class Transactions
	{
		/// <summary>
		/// The resources related to this filing
		/// </summary>
		[DataMember(Name = "links")]
		public TransactionsLinks Links { get; set; } = new();

		/// <summary>
		/// The date the filing was submitted to Companies House
		/// </summary>
		[DataMember(Name = "delivered_on")]
		public string? DeliveredOn { get; set; }

		/// <summary>
		/// Filing type which created, updated or satisfied the charge
		/// </summary>
		[DataMember(Name = "filing_type")]
		public string? FilingType { get; set; }

		/// <summary>
		/// The insolvency case related to this filing
		/// </summary>
		[DataMember(Name = "insolvency_case_number")]
		public int? InsolvencyCaseNumber { get; set; }

		/// <summary>
		/// The id of the filing
		/// </summary>
		[DataMember(Name = "transaction_id")]
		public int? TransactionID { get; set; }
	}
}
