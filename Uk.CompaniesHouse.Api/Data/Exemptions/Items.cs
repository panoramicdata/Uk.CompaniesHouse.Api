using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// Items
	/// </summary>
	[DataContract]
	public class Items
	{
		///<summary>
		/// Exempt from
		/// </summary>
		[DataMember(Name = "exempt_from")]
		public string ExemptFrom { get; set; } = string.Empty;

		///<summary>
		/// Exempt to
		/// </summary>
		[DataMember(Name = "exempt_to")]
		public string? ExemptTo { get; set; }
	}
}
