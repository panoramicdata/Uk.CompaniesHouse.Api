using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Registered office address details
	/// </summary>
	[DataContract]
	public class RegisteredOfficeAddress
	{
		/// <summary>
		/// Address line 1
		/// </summary>
		[DataMember(Name = "address_line_1")]
		public string AddressLine1 { get; set; } = string.Empty;

		/// <summary>
		/// Address line 2
		/// </summary>
		[DataMember(Name = "address_line_2")]
		public string? AddressLine2 { get; set; }

		/// <summary>
		/// Country
		/// </summary>
		[DataMember(Name = "country")]
		public string Country { get; set; } = string.Empty;

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string? Etag { get; set; }

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string? Kind { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links? Links { get; set; }

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
		public string Premises { get; set; } = string.Empty;

		/// <summary>
		/// Region
		/// </summary>
		[DataMember(Name = "region")]
		public string? Region { get; set; }

		/// <summary>
		/// Care of
		/// </summary>
		[DataMember(Name = "care_of")]
		public string? CareOf { get; set; }
	}
}
