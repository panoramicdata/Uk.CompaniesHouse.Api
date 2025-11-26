using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Annual return
/// </summary>
[DataContract]
public class AnnualReturn
{
	/// <summary>
	/// The date the last annual return was made up to.
	/// </summary>
	[DataMember(Name = "last_made_up_to")]
	public string? LastMadeUpTo { get; set; }

	/// <summary>
	/// The date the next annual return should be made up to.
	/// </summary>
	[DataMember(Name = "next_made_up_to")]
	public string? NextMadeUpTo { get; set; }

	/// <summary>
	/// The date the next annual return is due.
	/// </summary>
	[DataMember(Name = "next_due")]
	public string? NextDue { get; set; }

	/// <summary>
	/// Flag indicating if the annual return is overdue.
	/// </summary>
	[DataMember(Name = "overdue")]
	public bool? Overdue { get; set; }
}
