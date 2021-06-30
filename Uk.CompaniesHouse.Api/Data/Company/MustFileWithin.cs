using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Must file within
	/// </summary>
	[DataContract]
	public class MustFileWithin
	{
		/// <summary>
		/// Months
		/// </summary>
		[DataMember(Name = "months")]
		public int? Type { get; set; }
	}
}
