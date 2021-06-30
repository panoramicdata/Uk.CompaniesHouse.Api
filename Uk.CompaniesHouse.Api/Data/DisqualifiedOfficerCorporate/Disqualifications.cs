using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;
using Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerCorporate
{
	/// <summary>
	/// Disqualifications
	/// </summary>
	[DataContract]
	public class Disqualifications
	{
		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Case identifier
		/// </summary>
		[DataMember(Name = "case_identifier")]
		public string? CaseIdentifier { get; set; }

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
		/// Disqualification type
		/// </summary>
		[DataMember(Name = "disqualification_type")]
		public string DisqualificationType { get; set; } = string.Empty;

		/// <summary>
		/// Disqualified from
		/// </summary>
		[DataMember(Name = "disqualified_from")]
		public string DisqualifiedFrom { get; set; } = string.Empty;

		/// <summary>
		/// Disqualified until
		/// </summary>
		[DataMember(Name = "disqualified_until")]
		public string DisqualifiedUntil { get; set; } = string.Empty;

		/// <summary>
		/// Heard on
		/// </summary>
		[DataMember(Name = "heard_on")]
		public string? HeardOn { get; set; }

		/// <summary>
		/// Last variation
		/// </summary>
		[DataMember(Name = "last_variation")]
		public List<LastVariation>? LastVariation { get; set; }

		/// <summary>
		/// Reason
		/// </summary>
		[DataMember(Name = "reason")]
		public Reason Reason { get; set; } = new();

		/// <summary>
		/// Undertaken on
		/// </summary>
		[DataMember(Name = "undertaken_on")]
		public string? UndertakenOn { get; set; }
	}
}
