using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Statement
	/// </summary>
	[DataContract]
	public class Statement
	{
		/// <summary>
		/// Ceased on
		/// </summary>
		[DataMember(Name = "ceased_on")]
		public string? CeasedOn { get; set; }

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Linked psc name
		/// </summary>
		[DataMember(Name = "linked_psc_name")]
		public string? LinkedPscName { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public StatementLinks Links { get; set; } = new();

		/// <summary>
		/// Notified on
		/// </summary>
		[DataMember(Name = "notified_on")]
		public string NotifiedOn { get; set; } = string.Empty;

		/// <summary>
		/// Reason for company withdrawing
		/// </summary>
		[DataMember(Name = "restrictions_notice_withdrawal_reason")]
		public string? RestrictionsNoticeWithdrawalReason { get; set; }

		/// <summary>
		/// Statement
		/// </summary>
		[DataMember(Name = "statement")]
		public string TypeOfStatement { get; set; } = string.Empty;
	}
}
