using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Appointment Links
	/// </summary>
	[DataContract]
	public class AppointmentLinks
	{
		/// <summary>
		/// Self link
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;

		/// <summary>
		/// Officer link
		/// </summary>
		[DataMember(Name = "officer")]
		public Officer Officer { get; set; } = new();
	}
}
