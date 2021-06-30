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
		/// Line 2 of address
		/// </summary>
		[DataMember(Name = "address_line_2")]
		public string? AddressLine2 { get; set; }

		/// <summary>
		/// Care of
		/// </summary>
		[DataMember(Name = "care_of")]
		public string? CareOf { get; set; }

		/// <summary>
		/// Country
		/// </summary>
		[DataMember(Name = "country")]
		public string? Country { get; set; }

		/// <summary>
		/// Locality
		/// </summary>
		[DataMember(Name = "locality")]
		public string Locality { get; set; } = string.Empty;

		/// <summary>
		/// PO Box
		/// </summary>
		[DataMember(Name = "po_box")]
		public string? PoBox { get; set; }

		/// <summary>
		/// Postal code
		/// </summary>
		[DataMember(Name = "postal_code")]
		public string? PostalCode { get; set; }

		/// <summary>
		/// Premises
		/// </summary>
		[DataMember(Name = "premises")]
		public string? Premises { get; set; }

		/// <summary>
		/// Region
		/// </summary>
		[DataMember(Name = "region")]
		public string? Region { get; set; }
	}
}