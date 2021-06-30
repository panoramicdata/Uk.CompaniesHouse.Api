using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Originating registry
	/// </summary>
	[DataContract]
	public class OriginatingRegistry
	{
		/// <summary>
		/// Country
		/// </summary>
		[DataMember(Name = "country")]
		public string? Country { get; set; }

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string? Name { get; set; }
	}
}
