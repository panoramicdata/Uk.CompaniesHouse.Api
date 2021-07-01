using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class PWSCLinks
	{
		/// <summary>
		/// The URL of the resource.
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;

		/// <summary>
		/// The URL of the statement linked to this person with significant control.
		/// </summary>
		[DataMember(Name = "statement")]
		public string? Statement { get; set; }
	}
}
