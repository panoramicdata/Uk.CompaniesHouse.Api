using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers
{
	/// <summary>
	/// Identification
	/// </summary>
	[DataContract]
	public class Identification
	{
		/// <summary>
		/// The officer's identity type
		/// </summary>
		[DataMember(Name = "identification_type")]
		public string? IdentificationType { get; set; }

		/// <summary>
		/// The legal authority supervising the company.
		/// </summary>
		[DataMember(Name = "legal_authority")]
		public string? LegalAuthority { get; set; }

		/// <summary>
		/// The legal form of the company as defined by its country of registration.
		/// </summary>
		[DataMember(Name = "legal_form")]
		public string? LegalForm { get; set; }

		/// <summary>
		/// Place registered.
		/// </summary>
		[DataMember(Name = "place_registered")]
		public string? PlaceRegistered { get; set; }

		/// <summary>
		/// Company registration number.
		/// </summary>
		[DataMember(Name = "registration_number")]
		public string? RegistrationNumber { get; set; }
	}
}
