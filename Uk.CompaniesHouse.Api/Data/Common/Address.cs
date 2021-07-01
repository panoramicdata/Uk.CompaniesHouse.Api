using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Common
{
	/// <summary>
	/// Address
	/// </summary>
	[DataContract]
	public class Address
	{
		/// <summary>
		/// The first line of the address.
		/// </summary>
		[DataMember(Name = "address_line_1")]
		public string AddressLine1 { get; set; } = string.Empty;

		/// <summary>
		/// The second line of the address.
		/// </summary>
		[DataMember(Name = "address_line_2")]
		public string? AddressLine2 { get; set; }

		/// <summary>
		/// The care of name.
		/// </summary>
		[DataMember(Name = "care_of")]
		public string? CareOf { get; set; }

		/// <summary>
		/// The country.
		/// </summary>
		[DataMember(Name = "country")]
		public string? Country { get; set; }

		/// <summary>
		/// The locality e.g London.
		/// </summary>
		[DataMember(Name = "locality")]
		public string Locality { get; set; } = string.Empty;

		/// <summary>
		/// The post-office box number.
		/// </summary>
		[DataMember(Name = "po_box")]
		public string? PoBox { get; set; }

		/// <summary>
		/// The postal code e.g CF14 3UZ.
		/// </summary>
		[DataMember(Name = "postal_code")]
		public string? PostalCode { get; set; }

		/// <summary>
		/// The property name or number.
		/// </summary>
		[DataMember(Name = "premises")]
		public string? Premises { get; set; }

		/// <summary>
		/// The region e.g Surrey.
		/// </summary>
		[DataMember(Name = "region")]
		public string? Region { get; set; }
	}
}