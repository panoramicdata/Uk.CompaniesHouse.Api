using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History
{
	/// <summary>
	/// Any filings associated with the current item
	/// </summary>
	[DataContract]
	public class AssociatedFilings
	{
		/// <summary>
		/// The date the associated filing was processed.
		/// </summary>
		[DataMember(Name = "date")]
		public string Date { get; set; } = string.Empty;

		/// <summary>
		/// A description of the associated filing.
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// The type of the associated filing.
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
