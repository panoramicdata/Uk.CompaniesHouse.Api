using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// LLP Members links
	/// </summary>
	[DataContract]
	public class LlpMembersLinks
	{
		/// <summary>
		/// LLP members
		/// </summary>
		[DataMember(Name = "llp_members")]
		public string? LlpMembers { get; set; }
	}
}
