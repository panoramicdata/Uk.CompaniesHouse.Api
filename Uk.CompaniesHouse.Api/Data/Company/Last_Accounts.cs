using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Uk.CompaniesHouse.Api.Data.Company
{

	/// <summary>
	/// XXXXXXX
	/// </summary>
	[DataContract]
	public class Last_Accounts
	{

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string period_end_on { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string type { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string made_up_to { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string period_start_on { get; set; }
	}
}
