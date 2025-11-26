using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// Statement
/// </summary>
[DataContract]
public class Statement
{
	/// <summary>
	/// The date that Companies House was notified about the cessation of this person with significant control.
	/// </summary>
	[DataMember(Name = "ceased_on")]
	public string? CeasedOn { get; set; }

	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// Kind
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// The name of the psc linked to this statement.
	/// </summary>
	[DataMember(Name = "linked_psc_name")]
	public string? LinkedPscName { get; set; }

	/// <summary>
	/// A set of URLs related to the resource, including self.
	/// </summary>
	[DataMember(Name = "links")]
	public StatementLinks Links { get; set; } = new();

	/// <summary>
	/// The date that the person with significant control statement was processed by Companies House.
	/// </summary>
	[DataMember(Name = "notified_on")]
	public string NotifiedOn { get; set; } = string.Empty;

	/// <summary>
	/// The reason for the company withdrawing a restrictions-notice-issued-to-psc statement
	/// </summary>
	[DataMember(Name = "restrictions_notice_withdrawal_reason")]
	public string? RestrictionsNoticeWithdrawalReason { get; set; }

	/// <summary>
	/// Indicates the type of statement filed.
	/// </summary>
	[DataMember(Name = "statement")]
	public string TypeOfStatement { get; set; } = string.Empty;
}
