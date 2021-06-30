using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class InsolvencyCasesLinks
	{
		/// <summary>
		/// Case
		/// </summary>
		[DataMember(Name = "case")]
		public string? Case { get; set; }
	}
}
