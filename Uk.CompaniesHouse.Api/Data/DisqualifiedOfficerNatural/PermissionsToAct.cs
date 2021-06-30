using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural
{
	/// <summary>
	/// Permissions to act
	/// </summary>
	[DataContract]
	public class PermissionsToAct
	{
		/// <summary>
		/// Company names
		/// </summary>
		[DataMember(Name = "company_names")]
		public List<string>? CompanyNames { get; set; }

		/// <summary>
		/// Court name
		/// </summary>
		[DataMember(Name = "court_name")]
		public string? CourtName { get; set; }

		/// <summary>
		/// Expires on
		/// </summary>
		[DataMember(Name = "expires_on")]
		public string ExpiresOn { get; set; } = string.Empty;

		/// <summary>
		/// Granted on
		/// </summary>
		[DataMember(Name = "granted_on")]
		public string GrantedOn { get; set; } = string.Empty;
	}
}
