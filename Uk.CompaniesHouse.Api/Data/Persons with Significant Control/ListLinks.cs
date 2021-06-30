using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class ListLinks
	{
		/// <summary>
		/// Persons with significant control list
		/// </summary>
		[DataMember(Name = "persons_with_significant_control_list")]
		public string? PersonsWithSignificantControlList { get; set; }

		/// <summary>
		/// Self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
