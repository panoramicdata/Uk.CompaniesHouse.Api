using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Account reference date
	/// </summary>
	[DataContract]
	public class AccountingReferenceDate
	{
		/// <summary>
		/// Month
		/// </summary>
		[DataMember(Name = "month")]
		public string Month { get; set; } = string.Empty;

		/// <summary>
		/// Day
		/// </summary>
		[DataMember(Name = "day")]
		public string Day { get; set; } = string.Empty;
	}
}
