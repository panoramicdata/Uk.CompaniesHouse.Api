using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Common
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class Links
	{
		/// <summary>
		/// URL to this resource.
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
