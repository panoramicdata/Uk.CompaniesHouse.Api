using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Exemptions
{
	/// <summary>
	/// Exemptions
	/// </summary>
	[DataContract]
	public class ExemptionsMain
	{
		///<summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		///<summary>
		/// Exemptions
		/// </summary>
		[DataMember(Name = "exemptions")]
		public Exemptions Exemptions { get; set; } = new();

		///<summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		///<summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();
	}
}
