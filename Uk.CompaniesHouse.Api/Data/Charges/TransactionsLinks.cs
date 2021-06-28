using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Transaction links
	/// </summary>
	[DataContract]
	public class TransactionsLinks
	{
		///<summary>
		///	Filing
		/// </summary>
		[DataMember(Name = "filing")]
		public string Filing { get; set; } = string.Empty;
	}
}
