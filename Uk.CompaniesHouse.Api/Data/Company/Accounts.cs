using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{

	/// <summary>
	/// XXXXXXX
	/// </summary>
	[DataContract]
	public class Accounts
	{

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public bool overdue { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public Accounting_Reference_Date accounting_reference_date { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public Last_Accounts last_accounts { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public Next_Accounts next_accounts { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string next_due { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string next_made_up_to { get; set; }
	}
}
