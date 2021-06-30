using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class StatementLinks
	{
		/// <summary>
		/// Person with significant control
		/// </summary>
		[DataMember(Name = "person_with_significant_control")]
		public string? PersonWithSignificantControl { get; set; }

		/// <summary>
		/// Self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
