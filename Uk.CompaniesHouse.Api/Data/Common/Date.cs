using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Common
{
	/// <summary>
	/// Date
	/// </summary>
	[DataContract]
	public class Date
	{
		/// <summary>
		/// Day
		/// </summary>
		[DataMember(Name = "day")]
		public int? Day { get; set; }

		/// <summary>
		/// Month
		/// </summary>
		[DataMember(Name = "month")]
		public int? Month { get; set; }
	}
}
