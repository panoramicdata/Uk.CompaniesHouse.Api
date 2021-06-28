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
		/// Link to self
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}
}
