using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class LlpUsualResidentialAddressLinks
	{
		/// <summary>
		/// LLP usual residential address
		/// </summary>
		[DataMember(Name = "llp_usual_residential_address")]
		public string? LlpUsualResidentialAddress { get; set; }
	}
}
