using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.UkEstablishments
{
	/// <summary>
	/// Items
	/// </summary>
	[DataContract]
	public class Items
	{
		/// <summary>
		/// Company name
		/// </summary>
		[DataMember(Name = "company_name")]
		public string CompanyName { get; set; } = string.Empty;

		/// <summary>
		/// Company number
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = string.Empty;

		/// <summary>
		/// Company status
		/// </summary>
		[DataMember(Name = "company_status")]
		public string CompanyStatus { get; set; } = string.Empty;

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public ItemsLinks Links { get; set; } = new();

		/// <summary>
		/// Locality
		/// </summary>
		[DataMember(Name = "locality")]
		public string? Locality { get; set; }
	}
}
