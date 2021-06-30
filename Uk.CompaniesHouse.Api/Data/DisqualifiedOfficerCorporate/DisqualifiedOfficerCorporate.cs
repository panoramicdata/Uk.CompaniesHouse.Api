using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerCorporate
{
	/// <summary>
	/// Disqualified corporate officer
	/// </summary>
	[DataContract]
	public class DisqualifiedOfficerCorporate
	{
		/// <summary>
		/// Company number
		/// </summary>
		[DataMember(Name = "company_number")]
		public string? CompanyNumber { get; set; }

		/// <summary>
		/// Country of registration
		/// </summary>
		[DataMember(Name = "country_of_registration")]
		public string? CountryOfRegistration { get; set; }

		/// <summary>
		/// Disqualifications
		/// </summary>
		[DataMember(Name = "disqualifications")]
		public List<Disqualifications> Disqualifications { get; set; } = new();

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Permissions to act
		/// </summary>
		[DataMember(Name = "permissions_to_act")]
		public List<PermissionsToAct>? PermissionsToAct { get; set; }
	}
}
