using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency;

/// <summary>
/// The dates specific to the case.
/// </summary>
[DataContract]
public class Dates
{
	///<summary>
	/// Describes what date is represented by the associated date element.
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	///<summary>
	/// The case date
	/// </summary>
	[DataMember(Name = "date")]
	public string Date { get; set; } = string.Empty;
}
