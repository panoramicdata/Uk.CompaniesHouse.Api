using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Name elements
	/// </summary>
	[DataContract]
	public class NameElements
	{
		/// <summary>
		/// Forename
		/// </summary>
		[DataMember(Name = "forename")]
		public string? Forename { get; set; }

		/// <summary>
		/// Other forenames
		/// </summary>
		[DataMember(Name = "other_forenames")]
		public string? OtherForenames { get; set; }

		/// <summary>
		/// Surname
		/// </summary>
		[DataMember(Name = "surname")]
		public string Surname { get; set; } = string.Empty;

		/// <summary>
		/// Title
		/// </summary>
		[DataMember(Name = "title")]
		public string? Title { get; set; }
	}
}
