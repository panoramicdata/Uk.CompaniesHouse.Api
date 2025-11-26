using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency;

/// <summary>
/// Cases
/// </summary>
[DataContract]
public class Cases
{
	///<summary>
	/// The practitioners for the case.
	/// </summary>
	[DataMember(Name = "practitioners")]
	public List<Practitioners> Practitioners { get; set; } = [];

	///<summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	///<summary>
	/// The case number.
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	///<summary>
	/// The dates specific to the case.
	/// </summary>
	[DataMember(Name = "dates")]
	public List<Dates> Dates { get; set; } = [];

	///<summary>
	/// The practitioners for the case.
	/// </summary>
	[DataMember(Name = "links")]
	public Links? Links { get; set; }

	/// <summary>
	/// The dates specific to the case.
	/// </summary>
	[DataMember(Name = "notes")]
	public List<string>? Notes { get; set; }
}
