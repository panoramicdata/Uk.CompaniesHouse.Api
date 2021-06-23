using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class OfficerLinks
	{
		/// <summary>
		/// Link to self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
