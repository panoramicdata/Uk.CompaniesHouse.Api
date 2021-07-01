using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Officers
{
	/// <summary>
	/// Officer links
	/// </summary>
	[DataContract]
	public class OfficerAppoint
	{
		/// <summary>
		/// Link to the officer appointment resource that this appointment is associated with.
		/// </summary>
		[DataMember(Name = "appointments")]
		public string Appointments { get; set; } = string.Empty;
	}
}
