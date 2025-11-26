using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Company profile
/// </summary>
[DataContract]
public class Company
{
	/// <summary>
	/// SIC codes for this company.
	/// </summary>
	[DataMember(Name = "sic_codes")]
	public List<string>? SicCodes { get; set; }

	/// <summary>
	/// The date when the company was created.
	/// </summary>
	[DataMember(Name = "date_of_creation")]
	public string CreationDate { get; set; } = string.Empty;

	/// <summary>
	/// The date of last full members list update.
	/// </summary>
	[DataMember(Name = "last_full_members_list_date")]
	public string? LastFullMembersListDate { get; set; }

	/// <summary>
	/// Registered office address
	/// </summary>
	[DataMember(Name = "registered_office_address")]
	public RegisteredOfficeAddress RegisteredOfficeAddress { get; set; } = new();

	/// <summary>
	/// The number of the company.
	/// </summary>
	[DataMember(Name = "company_number")]
	public string CompanyNumber { get; set; } = string.Empty;

	/// <summary>
	/// The name of the company.
	/// </summary>
	[DataMember(Name = "company_name")]
	public string CompanyName { get; set; } = string.Empty;

	/// <summary>
	/// The flag indicating if the company has been liquidated in the past.
	/// </summary>
	[DataMember(Name = "has_been_liquidated")]
	public bool? HasBeenLiquidated { get; set; }

	/// <summary>
	/// Company accounts information.
	/// </summary>
	[DataMember(Name = "accounts")]
	public Accounts? Accounts { get; set; }

	/// <summary>
	/// The status of the company.
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Flag indicating whether post can be delivered to the registered office.
	/// </summary>
	[DataMember(Name = "undeliverable_registered_office_address")]
	public bool? UndeliverableRegisteredOfficeAddress { get; set; }

	/// <summary>
	/// The jurisdiction specifies the political body responsible for the company.
	/// </summary>
	[DataMember(Name = "jurisdiction")]
	public string Jurisdiction { get; set; } = string.Empty;

	/// <summary>
	/// The type of the company.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// The flag indicating if the company has any charges..
	/// </summary>
	[DataMember(Name = "has_charges")]
	public bool? HasCharges { get; set; }

	/// <summary>
	/// The flag indicating if the company is a Community Interest Company.
	/// </summary>
	[DataMember(Name = "is_community_interest_company")]
	public bool? IsCommunityInterestCompany { get; set; }

	/// <summary>
	/// The company status
	/// </summary>
	[DataMember(Name = "company_status")]
	public string CompanyStatus { get; set; } = string.Empty;

	/// <summary>
	/// The flag indicating if the company has insolvency history.
	/// </summary>
	[DataMember(Name = "has_insolvency_history")]
	public bool? HasInsolvencyHistory { get; set; }

	/// <summary>
	/// Confirmation statement information.
	/// </summary>
	[DataMember(Name = "confirmation_statement")]
	public ConfirmationStatement ConfirmationStatement { get; set; } = new();

	/// <summary>
	/// Links.
	/// </summary>
	[DataMember(Name = "A set of URLs related to the resource, including self.")]
	public CompanyLinks Links { get; set; } = new();

	/// <summary>
	/// Flag indicating registered office address as been replaced.
	/// </summary>
	[DataMember(Name = "registered_office_is_in_dispute")]
	public bool? RegisteredOfficeIsInDispute { get; set; }

	/// <summary>
	/// Whether the company has super secure PSCS
	/// </summary>
	[DataMember(Name = "has_super_secure_pscs")]
	public bool HasSuperSecurePscs { get; set; }

	/// <summary>
	/// Flag indicating whether this company can file.
	/// </summary>
	[DataMember(Name = "can_file")]
	public bool CanFile { get; set; }

	/// <summary>
	/// Annual return information.
	/// </summary>
	[DataMember(Name = "annual_return")]
	public AnnualReturn? AnnualReturn { get; set; }

	/// <summary>
	/// UK branch of a foreign company.
	/// </summary>
	[DataMember(Name = "branch_company_details")]
	public BranchCompanyDetails? BranchCompanyDetails { get; set; }

	/// <summary>
	/// Extra details about the status of the company.
	/// </summary>
	[DataMember(Name = "company_status_detail")]
	public string? CompanyStatusDetail { get; set; }

	/// <summary>
	/// The date which the company was converted/closed or dissolved.
	/// </summary>
	[DataMember(Name = "date_of_cessation")]
	public string? DateOfCessation { get; set; }

	/// <summary>
	/// Foreign company details.
	/// </summary>
	[DataMember(Name = "foreign_company_details")]
	public ForeignCompanyDetails? ForeignCompanyDetails { get; set; }

	/// <summary>
	/// The previous names of this company.
	/// </summary>
	[DataMember(Name = "previous_company_names")]
	public List<PreviousCompanyNames>? PreviousCompanyNames { get; set; }
}