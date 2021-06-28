using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Person_with_Significant_Control
{
	/// <summary>
	/// Name details
	/// </summary>
	[DataContract]
	public class NameElements
	{
		/// <summary>
		/// Middle name
		/// </summary>
		[DataMember(Name = "middle_name")]
		public string MiddleName { get; set; } = string.Empty;

		/// <summary>
		/// Forename
		/// </summary>
		[DataMember(Name = "forename")]
		public string Forename { get; set; } = string.Empty;

		/// <summary>
		/// Surname
		/// </summary>
		[DataMember(Name = "surname")]
		public string Surname { get; set; } = string.Empty;

		/// <summary>
		/// Title
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; } = string.Empty;
	}
}
