using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural
{
	/// <summary>
	/// Reason
	/// </summary>
	[DataContract]
	public class Reason
	{
		/// <summary>
		/// An enumeration type tshat provides the description for the reason of disqualification.
		/// </summary>
		[DataMember(Name = "description_identifier")]
		public string DescriptionIdentifier { get; set; } = string.Empty;

		/// <summary>
		/// The section of the act under which the disqualification was made.
		/// </summary>
		[DataMember(Name = "section")]
		public string? Section { get; set; }

		/// <summary>
		/// An enumeration type that provides the law under which the disqualification was made.
		/// </summary>
		[DataMember(Name = "act")]
		public string Act { get; set; } = string.Empty;

		/// <summary>
		/// The article of the act under which the disqualification was made.
		/// </summary>
		[DataMember(Name = "article")]
		public string? Article { get; set; }
	}
}
