using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Accounts
/// </summary>
[DataContract]
public class Accounts
{
	/// <summary>
	/// Flag indicating if the company accounts are overdue.
	/// </summary>
	[DataMember(Name = "overdue")]
	public bool Overdue { get; set; }

	/// <summary>
	/// The Accounting Reference Date (ARD) of the company.
	/// </summary>
	[DataMember(Name = "accounting_reference_date")]
	public AccountingReferenceDate AccountingReferenceDate { get; set; } = new();

	/// <summary>
	/// The last company accounts filed.
	/// </summary>
	[DataMember(Name = "last_accounts")]
	public LastAccounts? LastAccounts { get; set; }

	/// <summary>
	/// The date the next company accounts are due.
	/// </summary>
	[DataMember(Name = "next_due")]
	public string? NextDue { get; set; }

	/// <summary>
	/// The date the next company accounts should be made up to.
	/// </summary>
	[DataMember(Name = "next_made_up_to")]
	public string NextMadeUpTo { get; set; } = string.Empty;
}
