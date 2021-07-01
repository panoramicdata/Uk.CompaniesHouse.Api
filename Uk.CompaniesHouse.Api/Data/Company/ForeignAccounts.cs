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
		/// Date account period starts under parent law.
		/// </summary>
		[DataMember(Name = "account_period_from")]
		public Date? AccountPeriodFrom { get; set; }

		/// <summary>
		/// Date account period ends under parent law.
		/// </summary>
		[DataMember(Name = "account_period_to")]
		public Date? AccountPeriodTo { get; set; }

		/// <summary>
		/// Time allowed from period end for disclosure of accounts under parent law.
		/// </summary>
		[DataMember(Name = "must_file_within")]
		public MustFileWithin? MustFileWithin { get; set; }
	}
}
