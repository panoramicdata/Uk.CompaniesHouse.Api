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
		///  Country in which company was incorporated.
		/// </summary>
		[DataMember(Name = "country")]
		public string? Country { get; set; }

		/// <summary>
		/// Identity of register in country of incorporation.
		/// </summary>
		[DataMember(Name = "name")]
		public string? Name { get; set; }
	}
}
