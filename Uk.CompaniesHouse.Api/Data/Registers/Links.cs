using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// A set of URLs related to the resource.
	/// </summary>
	[DataContract]
	public class Links
	{
		/// <summary>
		/// The URL of the transaction for the resource.
		/// </summary>
		[DataMember(Name = "filing")]
		public string Filing { get; set; } = string.Empty;
	}
}
