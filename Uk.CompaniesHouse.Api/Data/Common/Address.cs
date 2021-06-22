using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Common
{
	/// <summary>
	/// Address of officer
	/// </summary>
	[DataContract]
	public class Address
	{
		/// <summary>
		/// Line 1 of address
		/// </summary>
		[DataMember(Name = "address_line_1")]
		public string AddressLine1 { get; set; } = string.Empty;

		/// <summary>
		/// Country
		/// </summary>
		[DataMember(Name = "country")]
		public string Country { get; set; } = string.Empty;

		/// <summary>
		/// Locality
		/// </summary>
		[DataMember(Name = "locality")]
		public string Locality { get; set; } = string.Empty;

		/// <summary>
		/// Postal code
		/// </summary>
		[DataMember(Name = "postal_code")]
		public string PostalCode { get; set; } = string.Empty;

		/// <summary>
		/// Premises
		/// </summary>
		[DataMember(Name = "premises")]
		public string Premises { get; set; } = string.Empty;

		/// <summary>
		/// Region
		/// </summary>
		[DataMember(Name = "region")]
		public string Region { get; set; } = string.Empty;
	}
}