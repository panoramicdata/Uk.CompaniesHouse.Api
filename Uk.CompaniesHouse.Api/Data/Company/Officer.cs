using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	[DataContract]
	public class Officer
	{
		/// <summary>
		/// Self link
		/// </summary>
		[DataMember(Name = "appointments")]
		public string Appointments { get; set; } = string.Empty;
	}
}
