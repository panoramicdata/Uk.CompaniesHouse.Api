using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	[DataContract]
	public class Officer
	{
		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Nationality
		/// </summary>
		[DataMember(Name = "nationality")]
		public string Nationality { get; set; } = string.Empty;
	}

}
