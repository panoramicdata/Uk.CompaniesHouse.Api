using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural
{
	/// <summary>
	/// The latest variation made to the disqualification.
	/// </summary>
	[DataContract]
	public class LastVariation
	{
		/// <summary>
		/// The case identifier of the variation.
		/// </summary>
		[DataMember(Name = "case_identifier")]
		public string? CaseIdentifier { get; set; }

		/// <summary>
		/// The name of the court that handled the variation case.
		/// </summary>
		[DataMember(Name = "court_name")]
		public string? CourtName { get; set; }

		/// <summary>
		/// The date the variation was made against the disqualification.
		/// </summary>
		[DataMember(Name = "varied_on")]
		public string? VariedOn { get; set; }
	}
}
