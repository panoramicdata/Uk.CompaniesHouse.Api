using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Register director items
	/// </summary>
	[DataContract]
	public class RegistersItems
	{
		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// Registered on
		/// </summary>
		[DataMember(Name = "moved_on")]
		public string MovedOn { get; set; } = string.Empty;

		/// <summary>
		/// Register moved to
		/// </summary>
		[DataMember(Name = "register_moved_to")]
		public string RegisterMovedTo { get; set; } = string.Empty;
	}
}
