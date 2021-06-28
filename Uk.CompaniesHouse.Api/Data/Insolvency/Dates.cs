using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency
{
	/// <summary>
	/// Dates
	/// </summary>
	[DataContract]
	public class Dates
	{
		///<summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		///<summary>
		/// Date
		/// </summary>
		[DataMember(Name = "date")]
		public string Date { get; set; } = string.Empty;
	}
}
