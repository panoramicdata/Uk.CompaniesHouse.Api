using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Previous company names
	/// </summary>
	[DataContract]
	public class PreviousCompanyNames
	{
		/// <summary>
		/// Ceased on
		/// </summary>
		[DataMember(Name = "ceased_on")]
		public string CeasedOn { get; set; } = string.Empty;

		/// <summary>
		/// Effective from
		/// </summary>
		[DataMember(Name = "effective_from")]
		public string EffectiveFrom { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}
