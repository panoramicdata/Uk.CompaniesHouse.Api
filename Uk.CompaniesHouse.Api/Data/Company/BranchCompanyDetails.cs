using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Branch company details
	/// </summary>
	[DataContract]
	public class BranchCompanyDetails
	{
		/// <summary>
		/// Business activity
		/// </summary>
		[DataMember(Name = "business_activity")]
		public string? BusinessActivity { get; set; }

		/// <summary>
		/// Parent company name
		/// </summary>
		[DataMember(Name = "parent_company_name")]
		public string? ParentCompanyName { get; set; }

		/// <summary>
		/// Parent company number
		/// </summary>
		[DataMember(Name = "parent_company_number")]
		public string? ParentCompanyNumber { get; set; }
	}
}
