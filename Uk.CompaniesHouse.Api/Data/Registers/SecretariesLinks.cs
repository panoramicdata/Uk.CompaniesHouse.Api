using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class SecretariesLinks
	{
		/// <summary>
		/// Secretaries register
		/// </summary>
		[DataMember(Name = "secretaries_register")]
		public string? SecretariesRegister { get; set; }
	}
}
