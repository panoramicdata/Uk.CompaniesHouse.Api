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
	public class Links
	{

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string self { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string filing_history { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string officers { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string persons_with_significant_control { get; set; }
	}
}
