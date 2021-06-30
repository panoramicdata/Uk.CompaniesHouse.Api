using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Members
	/// </summary>
	[DataContract]
	public class Members
	{
		/// <summary>
		/// Items
		/// </summary>
		[DataMember(Name = "etag")]
		public List<RegistersItems> Items { get; set; } = new();

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public MembersLinks? Links { get; set; }

		/// <summary>
		/// Register type
		/// </summary>
		[DataMember(Name = "register_type")]
		public string RegisterType { get; set; } = string.Empty;

	}
}
