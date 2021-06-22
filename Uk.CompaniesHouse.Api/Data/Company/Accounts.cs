using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Accounts
	/// </summary>
	[DataContract]
	public class Accounts
	{
		/// <summary>
		/// Whether the accounts are overdue
		/// </summary>
		[DataMember(Name = "overdue")]
		public bool Overdue { get; set; }

		/// <summary>
		/// Accounting Reference Date
		/// </summary>
		[DataMember(Name = "accounting_reference_date")]
		public AccountingReferenceDate AccountingReferenceDate { get; set; } = new();

		/// <summary>
		/// Last Accounts
		/// </summary>
		[DataMember(Name = "last_accounts")]
		public Last_Accounts Last_Accounts { get; set; } = new();

		/// <summary>
		/// Next accounts
		/// </summary>
		[DataMember(Name = "next_accounts")]
		public Next_Accounts NextAccounts { get; set; } = new();

		/// <summary>
		/// Next due
		/// </summary>
		[DataMember(Name = "next_due")]
		public string NextDue { get; set; } = string.Empty;

		/// <summary>
		/// Next made up to
		/// </summary>
		[DataMember(Name = "next_made_up_to")]
		public string NextMadeUpTo { get; set; } = string.Empty;
	}
}
