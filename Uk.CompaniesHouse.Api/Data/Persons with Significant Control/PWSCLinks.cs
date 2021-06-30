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
		/// Self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;

		/// <summary>
		/// Statement
		/// </summary>
		[DataMember(Name = "statement")]
		public string? Statement { get; set; }
	}
}
