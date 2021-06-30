using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Foreign accounts
	/// </summary>
	[DataContract]
	public class ForeignAccounts
	{
		/// <summary>
		/// Account period from
		/// </summary>
		[DataMember(Name = "account_period_from")]
		public Date? AccountPeriodFrom { get; set; }

		/// <summary>
		/// Account period to
		/// </summary>
		[DataMember(Name = "account_period_to")]
		public Date? AccountPeriodTo { get; set; }

		/// <summary>
		/// Must file within
		/// </summary>
		[DataMember(Name = "must_file_within")]
		public MustFileWithin? MustFileWithin { get; set; }
	}
}
