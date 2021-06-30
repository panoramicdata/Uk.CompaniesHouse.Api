using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Identification
	/// </summary>
	[DataContract]
	public class CorporateIdentification
	{
		/// <summary>
		/// Country registered
		/// </summary>
		[DataMember(Name = "country_registered")]
		public string? CountryRegistered { get; set; }

		/// <summary>
		/// Legal authority
		/// </summary>
		[DataMember(Name = "legal_authority")]
		public string LegalAuthority { get; set; } = string.Empty;

		/// <summary>
		/// Legal form
		/// </summary>
		[DataMember(Name = "legal_form")]
		public string LegalForm { get; set; } = string.Empty;

		/// <summary>
		/// Place registered
		/// </summary>
		[DataMember(Name = "place_registered")]
		public string? PlaceRegistered { get; set; }

		/// <summary>
		/// Registration number
		/// </summary>
		[DataMember(Name = "registration_number")]
		public string? RegistrationNumber { get; set; }
	}
}