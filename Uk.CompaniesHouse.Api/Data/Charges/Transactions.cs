using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Transactions
	/// </summary>
	[DataContract]
	public class Transactions
	{
		///<summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public TransactionsLinks Links { get; set; } = new();

		///<summary>
		/// Delivered on
		/// </summary>
		[DataMember(Name = "delivered_on")]
		public string? DeliveredOn { get; set; }

		///<summary>
		/// Filing type
		/// </summary>
		[DataMember(Name = "filing_type")]
		public string? FilingType { get; set; }

		/// <summary>
		/// Insolvency case number
		/// </summary>
		[DataMember(Name = "insolvency_case_number")]
		public int? InsolvencyCaseNumber { get; set; }

		/// <summary>
		/// Transaction ID
		/// </summary>
		[DataMember(Name = "transaction_id")]
		public int? TransactionID { get; set; }
	}
}
