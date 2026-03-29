using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Officers;

/// <summary>
/// An individual officer appointment
/// </summary>
[DataContract]
public class OfficerAppointmentItem
{
	/// <summary>
	/// The correspondence address of the officer.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();

	/// <summary>
	/// The date on which the officer was appointed.
	/// </summary>
	[DataMember(Name = "appointed_on")]
	public string? AppointedOn { get; set; }

	/// <summary>
	/// The date the company was appointed to.
	/// </summary>
	[DataMember(Name = "appointed_to")]
	public AppointedTo? AppointedTo { get; set; }

	/// <summary>
	/// The officer's country of residence.
	/// </summary>
	[DataMember(Name = "country_of_residence")]
	public string? CountryOfResidence { get; set; }

	/// <summary>
	/// The name of the company the officer is appointed to.
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The company name that the officer is appointed to.
	/// </summary>
	[DataMember(Name = "appointed_to_company_name")]
	public string? AppointedToCompanyName { get; set; }

	/// <summary>
	/// Links to other resources associated with this appointment.
	/// </summary>
	[DataMember(Name = "links")]
	public OfficerAppointmentLinks? Links { get; set; }

	/// <summary>
	/// The officer's nationality.
	/// </summary>
	[DataMember(Name = "nationality")]
	public string? Nationality { get; set; }

	/// <summary>
	/// The officer's job title.
	/// </summary>
	[DataMember(Name = "occupation")]
	public string? Occupation { get; set; }

	/// <summary>
	/// Officer role.
	/// </summary>
	[DataMember(Name = "officer_role")]
	public string OfficerRole { get; set; } = string.Empty;

	/// <summary>
	/// The date on which the officer resigned.
	/// </summary>
	[DataMember(Name = "resigned_on")]
	public string? ResignedOn { get; set; }
}
