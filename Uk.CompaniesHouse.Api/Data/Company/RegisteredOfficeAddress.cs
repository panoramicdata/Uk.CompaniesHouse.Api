using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Registered office address details
	/// </summary>
	[DataContract]
	public class RegisteredOfficeAddress
	{
		/// <summary>
		/// Locality
		/// </summary>
		[DataMember(Name = "locality")]
		public string Locality { get; set; } = string.Empty;

		/// <summary>
		/// Address line 1
		/// </summary>
		[DataMember(Name = "address_line_1")]
		public string AddressLine1 { get; set; } = string.Empty;

		/// <summary>
		/// Postal code
		/// </summary>
		[DataMember(Name = "postal_code")]
		public string PostalCode { get; set; } = string.Empty;
	}
}
