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
	public class Accounting_Reference_Date
	{

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string month { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string day { get; set; }
	}
}
