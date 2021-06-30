using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class UsualResidentialAddressLinks
	{
		/// <summary>
		/// Usual residential address
		/// </summary>
		[DataMember(Name = "usual_residential_address")]
		public string? UsualResidentialAddress { get; set; }
	}
}
