using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Identification
	/// </summary>
	[DataContract]
	public class LegalPersonIdentification
	{
		/// <summary>
		/// Legal authority
		/// </summary>
		[DataMember(Name = "legal_authority")]
		public string LegalAuthority { get; set; } = string.Empty;

		/// <summary>
		/// Legal form
		/// </summary>
		[DataMember(Name = "legal_form")]
		public string LegalForm { get; set; } = string.Empty;
	}
}
