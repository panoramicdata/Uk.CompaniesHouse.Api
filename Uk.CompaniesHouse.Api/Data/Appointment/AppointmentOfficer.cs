using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Appointment
{
	[DataContract]
	public class AppointmentOfficer
	{
		/// <summary>
		/// Self link
		/// </summary>
		[DataMember(Name = "appointments")]
		public string Appointments { get; set; } = string.Empty;
	}
}
