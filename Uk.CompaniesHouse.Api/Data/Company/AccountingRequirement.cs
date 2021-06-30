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
		/// Foreign account type
		/// </summary>
		[DataMember(Name = "foreign_account_type")]
		public string? ForeignAccountType { get; set; }

		/// <summary>
		/// Terms of account publication
		/// </summary>
		[DataMember(Name = "terms_of_account_publication")]
		public string? TermsOfAccountPublication { get; set; }
	}
}
