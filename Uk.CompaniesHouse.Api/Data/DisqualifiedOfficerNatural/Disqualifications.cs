using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural
{
	/// <summary>
	/// Disqualifications
	/// </summary>
	[DataContract]
	public class Disqualifications
	{
		/// <summary>
		/// Disqualified until
		/// </summary>
		[DataMember(Name = "disqualified_until")]
		public string DisqualifiedUntil { get; set; } = string.Empty;

		/// <summary>
		/// Disqualified from
		/// </summary>
		[DataMember(Name = "disqualified_from")]
		public string DisqualifiedFrom { get; set; } = string.Empty;

		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Company names
		/// </summary>
		[DataMember(Name = "company_names")]
		public List<string> CompanyNames { get; set; } = new();

		/// <summary>
		/// Case identifier
		/// </summary>
		[DataMember(Name = "case_identifier")]
		public string CaseIdentifier { get; set; } = string.Empty;

		/// <summary>
		/// Reason
		/// </summary>
		[DataMember(Name = "XXX")]
		public Reason Reason { get; set; } = new();

		/// <summary>
		/// Disqualification type
		/// </summary>
		[DataMember(Name = "disqualification_type")]
		public string DisqualificationType { get; set; } = string.Empty;
	}
}
