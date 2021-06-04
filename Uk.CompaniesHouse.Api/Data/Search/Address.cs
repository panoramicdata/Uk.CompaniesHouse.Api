using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search
{

	[DataContract]
	public class Address
	{
		[DataMember(Name = "postal_code")]
		public string PostalCode { get; set; } = string.Empty;

		[DataMember(Name = "premises")]
		public string Premises { get; set; } = string.Empty;

		[DataMember(Name = "locality")]
		public string Locality { get; set; } = string.Empty;

		[DataMember(Name = "address_line_1")]
		public string AddressLine1 { get; set; } = string.Empty;
	}

}