using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Usual residential address
	/// </summary>
	[DataContract]
	public class UsualResidentialAddress
	{
		/// <summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<RegistersItems> Items { get; set; } = new();

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public UsualResidentialAddressLinks? Links { get; set; }

		/// <summary>
		/// Register type
		/// </summary>
		[DataMember(Name = "register_type")]
		public string RegisterType { get; set; } = string.Empty;
	}
}
