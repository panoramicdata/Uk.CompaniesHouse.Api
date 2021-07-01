using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// List of exemption periods.
	/// </summary>
	[DataContract]
	public class Items
	{
		///<summary>
		/// Exemption valid from.
		/// </summary>
		[DataMember(Name = "exempt_from")]
		public string ExemptFrom { get; set; } = string.Empty;

		///<summary>
		/// Exemption valid to.
		/// </summary>
		[DataMember(Name = "exempt_to")]
		public string? ExemptTo { get; set; }
	}
}
