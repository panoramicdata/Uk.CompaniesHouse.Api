using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Account reference date
/// </summary>
[DataContract]
public class AccountingReferenceDate
{
	/// <summary>
	/// The Accounting Reference Date (ARD) month.
	/// </summary>
	[DataMember(Name = "month")]
	public string Month { get; set; } = string.Empty;

	/// <summary>
	/// The Accounting Reference Date (ARD) day.
	/// </summary>
	[DataMember(Name = "day")]
	public string Day { get; set; } = string.Empty;
}
