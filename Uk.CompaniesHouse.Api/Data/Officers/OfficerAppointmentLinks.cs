using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers;

/// <summary>
/// Links associated with an officer appointment.
/// </summary>
[DataContract]
public class OfficerAppointmentLinks
{
	/// <summary>
	/// The link to the company profile for this appointment.
	/// </summary>
	[DataMember(Name = "company")]
	public string? Company { get; set; }
}
