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
		/// The country or state the corporate entity with significant control is registered in.
		/// </summary>
		[DataMember(Name = "country_registered")]
		public string? CountryRegistered { get; set; }

		/// <summary>
		/// The legal authority supervising the corporate entity with significant control.
		/// </summary>
		[DataMember(Name = "legal_authority")]
		public string LegalAuthority { get; set; } = string.Empty;

		/// <summary>
		/// The legal form of the corporate entity with significant control as defined by its country of registration.
		/// </summary>
		[DataMember(Name = "legal_form")]
		public string LegalForm { get; set; } = string.Empty;

		/// <summary>
		/// The place the corporate entity with significant control is registered.
		/// </summary>
		[DataMember(Name = "place_registered")]
		public string? PlaceRegistered { get; set; }

		/// <summary>
		/// The registration number of the corporate entity with significant control.
		/// </summary>
		[DataMember(Name = "registration_number")]
		public string? RegistrationNumber { get; set; }
	}
}