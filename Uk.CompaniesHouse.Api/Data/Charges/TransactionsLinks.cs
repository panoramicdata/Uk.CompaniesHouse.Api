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
		public string? Filing { get; set; }

		/// <summary>
		/// Insolvency case
		/// </summary>
		[DataMember(Name = "insolvency_case")]
		public string? InsolvencyCase { get; set; }
	}
}
