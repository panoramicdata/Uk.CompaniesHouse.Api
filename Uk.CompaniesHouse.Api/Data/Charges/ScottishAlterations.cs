using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Scottish alterations
	/// </summary>
	[DataContract]
	public class ScottishAlterations
	{
		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Has alterations to order?
		/// </summary>
		[DataMember(Name = "has_alterations_to_order")]
		public bool? HasAlterationsToOrder { get; set; }

		/// <summary>
		/// Has alterations to prohibitions?
		/// </summary>
		[DataMember(Name = "has_alterations_to_prohibitions")]
		public bool? HasAlterationsToProhibitions { get; set; }

		/// <summary>
		/// Has alterations to provisions
		/// </summary>
		[DataMember(Name = "has_alterations_to_provisions")]
		public bool? HasAlterationsToProvisions { get; set; }

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
