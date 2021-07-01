using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// A set of URLs related to the resource.
	/// </summary>
	[DataContract]
	public class MembersLinks
	{
		/// <summary>
		/// The URL for the resource.
		/// </summary>
		[DataMember(Name = "members")]
		public string? Members { get; set; }
	}
}
