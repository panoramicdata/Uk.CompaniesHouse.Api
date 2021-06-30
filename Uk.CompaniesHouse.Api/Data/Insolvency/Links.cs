using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class Links
	{
		///<summary>
		/// Charge
		/// </summary>
		[DataMember(Name = "charge")]
		public string? Charge { get; set; }
	}
}
