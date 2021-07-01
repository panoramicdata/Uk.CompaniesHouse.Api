using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// A document encapsulating the seperate elements of a person with significant control's name.
	/// </summary>
	[DataContract]
	public class NameElements
	{
		/// <summary>
		/// The forename of the person with significant control.
		/// </summary>
		[DataMember(Name = "forename")]
		public string? Forename { get; set; }

		/// <summary>
		/// Other forenames of the person with significant control.
		/// </summary>
		[DataMember(Name = "other_forenames")]
		public string? OtherForenames { get; set; }

		/// <summary>
		/// The surname of the person with significant control.
		/// </summary>
		[DataMember(Name = "surname")]
		public string Surname { get; set; } = string.Empty;

		/// <summary>
		/// Title of the person with significant control.
		/// </summary>
		[DataMember(Name = "title")]
		public string? Title { get; set; }
	}
}
