using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Common
{
	/// <summary>
	/// Date of birth
	/// </summary>
	[DataContract]
	public class DateOfBirth
	{
		/// <summary>
		/// Month
		/// </summary>
		[DataMember(Name = "month")]
		public string Month { get; set; } = string.Empty;

		/// <summary>
		/// Year
		/// </summary>
		[DataMember(Name = "year")]
		public string Year { get; set; } = string.Empty;
	}
}
