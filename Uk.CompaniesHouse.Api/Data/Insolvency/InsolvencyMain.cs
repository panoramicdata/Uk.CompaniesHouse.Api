using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency
{
	/// <summary>
	/// Insolvency
	/// </summary>
	[DataContract]
	public class InsolvencyMain
	{
		///<summary>
		/// Cases
		/// </summary>
		[DataMember(Name = "cases")]
		public List<Cases> Cases { get; set; } = new();

		///<summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;
	}
}
