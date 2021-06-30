using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class MembersLinks
	{
		/// <summary>
		/// Members
		/// </summary>
		[DataMember(Name = "members")]
		public string? Members { get; set; }
	}
}
