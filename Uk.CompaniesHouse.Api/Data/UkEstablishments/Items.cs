using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.UkEstablishments
{
	/// <summary>
	/// List of UK Establishment companies.
	/// </summary>
	[DataContract]
	public class Items
	{
		/// <summary>
		/// The name of the company.
		/// </summary>
		[DataMember(Name = "company_name")]
		public string CompanyName { get; set; } = string.Empty;

		/// <summary>
		/// The number of the company.
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = string.Empty;

		/// <summary>
		/// Company status.
		/// </summary>
		[DataMember(Name = "company_status")]
		public string CompanyStatus { get; set; } = string.Empty;

		/// <summary>
		/// Resources related to this company.
		/// </summary>
		[DataMember(Name = "links")]
		public ItemsLinks Links { get; set; } = new();

		/// <summary>
		/// The locality e.g London.
		/// </summary>
		[DataMember(Name = "locality")]
		public string? Locality { get; set; }
	}
}
