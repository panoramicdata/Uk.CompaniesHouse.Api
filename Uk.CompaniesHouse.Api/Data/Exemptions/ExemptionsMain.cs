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
		/// The ETag of the resource.
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		///<summary>
		/// Company exemptions information.
		/// </summary>
		[DataMember(Name = "exemptions")]
		public Exemptions Exemptions { get; set; } = new();

		///<summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		///<summary>
		/// A set of URLs related to the resource, including self.
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();
	}
}
