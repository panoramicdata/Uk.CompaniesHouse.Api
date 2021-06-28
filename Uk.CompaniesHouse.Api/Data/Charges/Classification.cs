using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Classification
	/// </summary>
	[DataContract]
	public class Classification
	{
		///<summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		///<summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
