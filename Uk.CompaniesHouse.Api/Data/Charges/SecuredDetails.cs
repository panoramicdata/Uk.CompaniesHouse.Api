using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Information about what is secured against this charge
	/// </summary>
	[DataContract]
	public class SecuredDetails
	{
		/// <summary>
		/// Details of the amount or obligation secured by the charge
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// The type of secured details.
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
