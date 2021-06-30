using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers
{
	/// <summary>
	/// Officer links
	/// </summary>
	[DataContract]
	public class OfficerLinks
	{
		/// <summary>
		/// Officer
		/// </summary>
		[DataMember(Name = "officer")]
		public OfficerAppoint Officer { get; set; } = new();

		/// <summary>
		/// Self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
