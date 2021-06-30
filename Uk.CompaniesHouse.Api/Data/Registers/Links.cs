using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class Links
	{
		/// <summary>
		/// Filing
		/// </summary>
		[DataMember(Name = "filing")]
		public string Filing { get; set; } = string.Empty;
	}
}
