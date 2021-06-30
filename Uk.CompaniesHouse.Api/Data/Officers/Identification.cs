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
		/// Identification type
		/// </summary>
		[DataMember(Name = "identification_type")]
		public string? IdentificationType { get; set; }

		/// <summary>
		/// Legal authority
		/// </summary>
		[DataMember(Name = "legal_authority")]
		public string? LegalAuthority { get; set; }

		/// <summary>
		/// Legal form
		/// </summary>
		[DataMember(Name = "legal_form")]
		public string? LegalForm { get; set; }

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
