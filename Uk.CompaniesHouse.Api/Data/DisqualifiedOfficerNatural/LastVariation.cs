using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural
{
	/// <summary>
	/// Last variation
	/// </summary>
	[DataContract]
	public class LastVariation
	{
		/// <summary>
		/// Case identifier
		/// </summary>
		[DataMember(Name = "case_identifier")]
		public string? CaseIdentifier { get; set; }

		/// <summary>
		/// Court name
		/// </summary>
		[DataMember(Name = "court_name")]
		public string? CourtName { get; set; }

		/// <summary>
		/// Varied on
		/// </summary>
		[DataMember(Name = "varied_on")]
		public string? VariedOn { get; set; }
	}
}
