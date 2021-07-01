using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// A set of URLs related to the resource, including self.
	/// </summary>
	[DataContract]
	public class CompanyLinks
	{
		/// <summary>
		/// The URL of the resource.
		/// </summary>
		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;

		/// <summary>
		/// The URL of the persons with significant control list resource.
		/// </summary>
		[DataMember(Name = "persons_with_significant_control")]
		public string? PersonsWithSignificantControl { get; set; }

		/// <summary>
		/// The URL of the persons with significant control statements list resource.
		/// </summary>
		[DataMember(Name = "persons_with_significant_control_statements")]
		public string? PersonsWithSignificantControlStatements { get; set; }

		/// <summary>
		/// The URL of the registers resource for this company
		/// </summary>
		[DataMember(Name = "registers")]
		public string? Registers { get; set; }
	}
}
