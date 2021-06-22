using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Company
	/// </summary>
	[DataContract]
	public class Company
	{
		/// <summary>
		/// SIC Codes
		/// </summary>
		[DataMember(Name = "sic_codes")]
		public List<string> SicCodes { get; set; } = new();

		/// <summary>
		/// Creation date
		/// </summary>
		[DataMember(Name = "date_of_creation")]
		public string CreationDate { get; set; } = string.Empty;

		/// <summary>
		/// Last full members list date
		/// </summary>
		[DataMember(Name = "last_full_members_list_date")]
		public string LastFullMembersListDate { get; set; } = string.Empty;

		/// <summary>
		/// Registered office address
		/// </summary>
		[DataMember(Name = "registered_office_address")]
		public RegisteredOfficeAddress RegisteredOfficeAddress { get; set; } = new();

		/// <summary>
		/// Company number
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = string.Empty;

		/// <summary>
		/// Company name
		/// </summary>
		[DataMember(Name = "company_name")]
		public string CompanyName { get; set; } = string.Empty;

		/// <summary>
		/// Whether the company has been liquidated
		/// </summary>
		[DataMember(Name = "has_been_liquidated")]
		public bool HasBeenLiquidated { get; set; }

		/// <summary>
		/// Accounts
		/// </summary>
		[DataMember(Name = "accounts")]
		public Accounts Accounts { get; set; } = new();

		/// <summary>
		/// Status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		/// <summary>
		/// Undeliverable registered office address
		/// </summary>
		[DataMember(Name = "undeliverable_registered_office_address")]
		public bool UndeliverableRegisteredOfficeAddress { get; set; }

		/// <summary>
		/// Jurisdiction
		/// </summary>
		[DataMember(Name = "jurisdiction")]
		public string Jurisdiction { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// E-Tag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Whether the company has charges.
		/// </summary>
		[DataMember(Name = "has_charges")]
		public bool HasCharges { get; set; }

		/// <summary>
		/// The company status
		/// </summary>
		[DataMember(Name = "company_status")]
		public string CompanyStatus { get; set; } = string.Empty;

		/// <summary>
		/// Whether the company has insolvency history
		/// </summary>
		[DataMember(Name = "has_insolvency_history")]
		public bool HasInsolvencyHistory { get; set; }

		/// <summary>
		/// Confirmation statement.
		/// </summary>
		[DataMember(Name = "confirmation_statement")]
		public ConfirmationStatement ConfirmationStatement { get; set; } = new();

		/// <summary>
		/// Links.
		/// </summary>
		[DataMember(Name = "links")]
		public CompanyLinks Links { get; set; } = new();

		/// <summary>
		/// Whether the registered office is in dispute.
		/// </summary>
		[DataMember(Name = "registered_office_is_in_dispute")]
		public bool RegisteredOfficeIsInDispute { get; set; }

		/// <summary>
		/// Whether the company has super secure PSCS
		/// </summary>
		[DataMember(Name = "has_super_secure_pscs")]
		public bool HasSuperSecurePscs { get; set; }

		/// <summary>
		/// Whether the company can file.
		/// </summary>
		[DataMember(Name = "can_file")]
		public bool CanFile { get; set; }
	}
}