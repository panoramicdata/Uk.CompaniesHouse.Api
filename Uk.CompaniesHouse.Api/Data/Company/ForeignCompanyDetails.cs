using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Foreign company details
	/// </summary>
	[DataContract]
	public class ForeignCompanyDetails
	{
		/// <summary>
		/// Accounting requirement
		/// </summary>
		[DataMember(Name = "accounting_requirement")]
		public AccountingRequirement? AccountingRequirement { get; set; }

		/// <summary>
		/// Accounts
		/// </summary>
		[DataMember(Name = "accounts")]
		public ForeignAccounts? ForeignAccounts { get; set; }

		/// <summary>
		/// Business activity
		/// </summary>
		[DataMember(Name = "business_activity")]
		public string? BusinessActivity { get; set; }

		/// <summary>
		/// Company type
		/// </summary>
		[DataMember(Name = "company_type")]
		public string? CompanyType { get; set; }

		/// <summary>
		/// Governed by
		/// </summary>
		[DataMember(Name = "governed_by")]
		public string? GovernedBy { get; set; }

		/// <summary>
		/// Is it a financial or credit institution
		/// </summary>
		[DataMember(Name = "is_a_credit_finance_institution")]
		public bool? IsACreditFinanceInstitution { get; set; }

		/// <summary>
		/// Originating registry
		/// </summary>
		[DataMember(Name = "originating_registry")]
		public OriginatingRegistry? OriginatingRegistry { get; set; }

		/// <summary>
		/// Registration number
		/// </summary>
		[DataMember(Name = "registration_number")]
		public string? RegistrationNumber { get; set; }
	}
}
