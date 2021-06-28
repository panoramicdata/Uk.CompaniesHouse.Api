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
		public string DeliveredOn { get; set; } = string.Empty;

		///<summary>
		/// Filing type
		/// </summary>
		[DataMember(Name = "filing_type")]
		public string FilingType { get; set; } = string.Empty;
	}
}
