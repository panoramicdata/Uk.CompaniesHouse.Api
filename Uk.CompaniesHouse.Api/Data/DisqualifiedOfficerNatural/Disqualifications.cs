using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural;

/// <summary>
/// The officer's disqualifications.
/// </summary>
[DataContract]
public class Disqualifications
{
	/// <summary>
	/// The date that the disqualification ends.
	/// </summary>
	[DataMember(Name = "disqualified_until")]
	public string DisqualifiedUntil { get; set; } = string.Empty;

	/// <summary>
	/// The date that the disqualification starts.
	/// </summary>
	[DataMember(Name = "disqualified_from")]
	public string DisqualifiedFrom { get; set; } = string.Empty;

	/// <summary>
	/// The address of the disqualified officer as provided by the disqualifying authority.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();

	/// <summary>
	/// The companies in which the misconduct took place.
	/// </summary>
	[DataMember(Name = "company_names")]
	public List<string>? CompanyNames { get; set; }

	/// <summary>
	/// The case identifier of the disqualification.
	/// </summary>
	[DataMember(Name = "case_identifier")]
	public string? CaseIdentifier { get; set; }

	/// <summary>
	/// The reason for the disqualification.
	/// </summary>
	[DataMember(Name = "reason")]
	public Reason Reason { get; set; } = new();

	/// <summary>
	/// An enumeration type that provides the disqualifying authority that handled the disqualification case.
	/// </summary>
	[DataMember(Name = "disqualification_type")]
	public string DisqualificationType { get; set; } = string.Empty;

	/// <summary>
	/// The name of the court that handled the disqualification case.
	/// </summary>
	[DataMember(Name = "court_name")]
	public string? CourtName { get; set; }

	/// <summary>
	/// The date the disqualification hearing was on.
	/// </summary>
	[DataMember(Name = "heard_on")]
	public string? HeardOn { get; set; }

	/// <summary>
	/// The latest variation made to the disqualification.
	/// </summary>
	[DataMember(Name = "court_name")]
	public List<LastVariation>? LastVariation { get; set; }

	/// <summary>
	/// The date the disqualification undertaking was agreed on.
	/// </summary>
	[DataMember(Name = "undertaken_on")]
	public string? UndertakenOn { get; set; }
}
