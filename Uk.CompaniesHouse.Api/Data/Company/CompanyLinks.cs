using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class CompanyLinks
	{
		/// <summary>
		/// Link to self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;

		/// <summary>
		/// Link to filing history
		/// </summary>
		[DataMember(Name = "filing_history")]
		public string FilingHistory { get; set; } = string.Empty;

		/// <summary>
		/// Link to list of officers
		/// </summary>
		[DataMember(Name = "officers")]
		public string Officers { get; set; } = string.Empty;

		/// <summary>
		/// Link to profile of person(s) with significant control
		/// </summary>
		[DataMember(Name = "persons_with_significant_control")]
		public string PersonsWithSignificantControl { get; set; } = string.Empty;
	}
}
