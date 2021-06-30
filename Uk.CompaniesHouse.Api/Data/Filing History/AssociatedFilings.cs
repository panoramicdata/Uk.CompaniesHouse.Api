using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Associated filings
	/// </summary>
	[DataContract]
	public class AssociatedFilings
	{
		/// <summary>
		/// Date
		/// </summary>
		[DataMember(Name = "date")]
		public string Date { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
