using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// A set of URLs related to the resource.
	/// </summary>
	[DataContract]
	public class LlpUsualResidentialAddressLinks
	{
		/// <summary>
		/// The URL for the resource.
		/// </summary>
		[DataMember(Name = "llp_usual_residential_address")]
		public string? LlpUsualResidentialAddress { get; set; }
	}
}
