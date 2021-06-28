using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Person_with_Significant_Control
{
	/// <summary>
	/// Filing history links
	/// </summary>
	[DataContract]
	public class PersonWithSignificantControlLinks
	{
		/// <summary>
		/// Self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
