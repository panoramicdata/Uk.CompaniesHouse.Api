using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Appointment
{
	/// <summary>
	/// Appointment details
	/// </summary>
	[DataContract]
	public class Appointment
	{
		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public AppointmentLinks Links { get; set; } = new();

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Nationality
		/// </summary>
		[DataMember(Name = "nationality")]
		public string Nationality { get; set; } = string.Empty;

		/// <summary>
		/// Occupation
		/// </summary>
		[DataMember(Name = "occupation")]
		public string Occupation { get; set; } = string.Empty;

		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Appointed on date
		/// </summary>
		[DataMember(Name = "appointed_on")]
		public string AppointedOn { get; set; } = string.Empty;

		/// <summary>
		/// Country of residence
		/// </summary>
		[DataMember(Name = "country_of_residence")]
		public string CountryOfResidence { get; set; } = string.Empty;

		/// <summary>
		/// Date of birth
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public DateOfBirth DateOfBirth { get; set; } = new();

		/// <summary>
		/// Role
		/// </summary>
		[DataMember(Name = "officer_role")]
		public string OfficerRole { get; set; } = string.Empty;
	}
}
