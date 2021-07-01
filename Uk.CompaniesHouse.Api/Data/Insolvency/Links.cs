using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency
{
	/// <summary>
	/// The practitioners for the case.
	/// </summary>
	[DataContract]
	public class Links
	{
		///<summary>
		/// The link to the charge this case is lodged against.
		/// </summary>
		[DataMember(Name = "charge")]
		public string? Charge { get; set; }
	}
}
