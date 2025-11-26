using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Next accounts
/// </summary>
[DataContract]
public class Next_Accounts
{
	/// <summary>
	/// Period start on
	/// </summary>
	[DataMember(Name = "period_start_on")]
	public string PeriodStartOn { get; set; } = string.Empty;

	/// <summary>
	/// Due on
	/// </summary>
	[DataMember(Name = "due_on")]
	public string DueOn { get; set; } = string.Empty;

	/// <summary>
	/// Overdue
	/// </summary>
	[DataMember(Name = "overdue")]
	public bool Overdue { get; set; }

	/// <summary>
	/// Period end on
	/// </summary>
	[DataMember(Name = "period_end_on")]
	public string PeriodEndOn { get; set; } = string.Empty;
}
