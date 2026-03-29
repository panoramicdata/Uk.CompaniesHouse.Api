using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers;

/// <summary>
/// The company the officer has been appointed to.
/// </summary>
[DataContract]
public class AppointedTo
{
	/// <summary>
	/// The company number.
	/// </summary>
	[DataMember(Name = "company_number")]
	public string? CompanyNumber { get; set; }

	/// <summary>
	/// The company name.
	/// </summary>
	[DataMember(Name = "company_name")]
	public string? CompanyName { get; set; }

	/// <summary>
	/// The company status.
	/// </summary>
	[DataMember(Name = "company_status")]
	public string? CompanyStatus { get; set; }
}
