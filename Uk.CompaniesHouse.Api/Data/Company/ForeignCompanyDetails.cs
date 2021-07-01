using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Foreign company details.
	/// </summary>
	[DataContract]
	public class ForeignCompanyDetails
	{
		/// <summary>
		/// Accounts requirement.
		/// </summary>
		[DataMember(Name = "accounting_requirement")]
		public AccountingRequirement? AccountingRequirement { get; set; }

		/// <summary>
		/// Foreign company account information.
		/// </summary>
		[DataMember(Name = "accounts")]
		public ForeignAccounts? ForeignAccounts { get; set; }

		/// <summary>
		/// Type of business undertaken by the company.
		/// </summary>
		[DataMember(Name = "business_activity")]
		public string? BusinessActivity { get; set; }

		/// <summary>
		/// Legal form of the company in the country of incorporation.
		/// </summary>
		[DataMember(Name = "company_type")]
		public string? CompanyType { get; set; }

		/// <summary>
		/// Law governing the company in country of incorporation.
		/// </summary>
		[DataMember(Name = "governed_by")]
		public string? GovernedBy { get; set; }

		/// <summary>
		/// Is it a financial or credit institution.
		/// </summary>
		[DataMember(Name = "is_a_credit_finance_institution")]
		public bool? IsACreditFinanceInstitution { get; set; }

		/// <summary>
		/// Company origin informations
		/// </summary>
		[DataMember(Name = "originating_registry")]
		public OriginatingRegistry? OriginatingRegistry { get; set; }

		/// <summary>
		/// Registration number in company of incorporation.
		/// </summary>
		[DataMember(Name = "registration_number")]
		public string? RegistrationNumber { get; set; }
	}
}
