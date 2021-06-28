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
		/// Description identifier
		/// </summary>
		[DataMember(Name = "description_identifier")]
		public string DescriptionIdentifier { get; set; } = string.Empty;

		/// <summary>
		/// Section
		/// </summary>
		[DataMember(Name = "section")]
		public string Section { get; set; } = string.Empty;

		/// <summary>
		/// Act
		/// </summary>
		[DataMember(Name = "act")]
		public string Act { get; set; } = string.Empty;
	}
}
