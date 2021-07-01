using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Details of super secure person
	/// </summary>
	[DataContract]
	public class SuperSecure
	{
		/// <summary>
		/// Presence of that indicator means the super secure person status is ceased
		/// </summary>
		[DataMember(Name = "ceased")]
		public bool? Ceased { get; set; }

		/// <summary>
		/// Description of the super secure legal statement
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// The ETag of the resource.
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// A set of URLs related to the resource, including self.
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();
	}
}
