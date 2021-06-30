using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.UkEstablishments
{
	/// <summary>
	/// UK Establishments
	/// </summary>
	[DataContract]
	public class UkEstablishments
	{
		///<summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links? Links { get; set; }

		///<summary>
		/// Items
		/// </summary>
		[DataMember(Name = "items")]
		public List<Items> Items { get; set; } = new();

		///<summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		///<summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;
	}
}
