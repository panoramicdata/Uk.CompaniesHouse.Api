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
		/// List of insolvency cases.
		/// </summary>
		[DataMember(Name = "cases")]
		public List<Cases> Cases { get; set; } = new();

		///<summary>
		/// The ETag of the resource.
		/// </summary>s
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		///<summary>
		/// Company insolvency status details
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;
	}
}