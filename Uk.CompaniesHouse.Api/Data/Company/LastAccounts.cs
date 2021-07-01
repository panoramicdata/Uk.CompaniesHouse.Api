using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Last accounts
	/// </summary>
	[DataContract]
	public class LastAccounts
	{
		/// <summary>
		/// The type of the last company accounts filed.
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// The date the last company accounts were made up to.
		/// </summary>
		[DataMember(Name = "made_up_to")]
		public string MadeUpTo { get; set; } = string.Empty;
	}
}
