using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// A set of URLs related to the resource.
	/// </summary>
	[DataContract]
	public class UsualResidentialAddressLinks
	{
		/// <summary>
		/// The URL for the resource.
		/// </summary>
		[DataMember(Name = "usual_residential_address")]
		public string? UsualResidentialAddress { get; set; }
	}
}
