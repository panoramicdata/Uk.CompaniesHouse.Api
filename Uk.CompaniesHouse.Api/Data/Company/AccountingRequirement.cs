using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Accounting requirement
	/// </summary>
	[DataContract]
	public class AccountingRequirement
	{
		/// <summary>
		/// Type of accounting requirement that applies.
		/// </summary>
		[DataMember(Name = "foreign_account_type")]
		public string? ForeignAccountType { get; set; }

		/// <summary>
		/// Describes how the publication date is derived.
		/// </summary>
		[DataMember(Name = "terms_of_account_publication")]
		public string? TermsOfAccountPublication { get; set; }
	}
}
