using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers
{
	/// <summary>
	/// Former names
	/// </summary>
	[DataContract]
	public class FormerNames
	{
		/// <summary>
		/// Former forenames
		/// </summary>
		[DataMember(Name = "forenames")]
		public string? Forenames { get; set; }

		/// <summary>
		/// Former surnames
		/// </summary>
		[DataMember(Name = "surname")]
		public string? Type { get; set; }
	}
}
