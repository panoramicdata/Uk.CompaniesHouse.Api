using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Company registers
	/// </summary>
	[DataContract]
	public class RegistersMain
	{
		/// <summary>
		/// The number of the company.
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = string.Empty;

		/// <summary>
		/// The ETag of the resource.
		/// </summary>
		[DataMember(Name = "etag")]
		public string? Etag { get; set; }

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

		/// <summary>
		/// Company registers information.
		/// </summary>
		[DataMember(Name = "registers")]
		public Registers Registers { get; set; } = new();
	}
}
