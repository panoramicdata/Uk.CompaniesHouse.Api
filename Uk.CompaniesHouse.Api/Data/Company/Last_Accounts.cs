using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Last accounts
	/// </summary>
	[DataContract]
	public class Last_Accounts
	{
		/// <summary>
		/// Period ended on
		/// </summary>
		[DataMember(Name = "period_end_on")]
		public string PeriodEndOn { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Made up to
		/// </summary>
		[DataMember(Name = "made_up_to")]
		public string MadeUpTo { get; set; } = string.Empty;

		/// <summary>
		/// Period start on
		/// </summary>
		[DataMember(Name = "period_start_on")]
		public string PeriodStartOn { get; set; } = string.Empty;
	}
}
