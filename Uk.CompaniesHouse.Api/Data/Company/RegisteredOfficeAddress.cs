using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{

	/// <summary>
	/// XXXXXXX
	/// </summary>
	[DataContract]
	public class RegisteredOfficeAddress
	{
		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string locality { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string address_line_1 { get; set; }

		/// <summary>
		/// XXXXXXXXX
		/// </summary>
		[DataMember(Name = "XXXXXXX")]
		public string postal_code { get; set; }
	}
}
