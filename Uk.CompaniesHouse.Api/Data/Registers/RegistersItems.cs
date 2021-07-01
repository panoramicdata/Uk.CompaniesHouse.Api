using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Register items
	/// </summary>
	[DataContract]
	public class RegistersItems
	{
		/// <summary>
		/// A set of URLs related to the resource.
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// The date registered on
		/// </summary>
		[DataMember(Name = "moved_on")]
		public string MovedOn { get; set; } = string.Empty;

		/// <summary>
		/// Location of registration
		/// </summary>
		[DataMember(Name = "register_moved_to")]
		public string RegisterMovedTo { get; set; } = string.Empty;
	}
}
