using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// A set of URLs related to the resource.
	/// </summary>
	[DataContract]
	public class SecretariesLinks
	{
		/// <summary>
		/// The URL for the resource.
		/// </summary>
		[DataMember(Name = "secretaries_register")]
		public string? SecretariesRegister { get; set; }
	}
}
