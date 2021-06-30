using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Officers
{
	/// <summary>
	/// List of officers
	/// </summary>
	[DataContract]
	public class Officer
	{
		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Appointed on
		/// </summary>
		[DataMember(Name = "appointed_on")]
		public string AppointedOn { get; set; } = string.Empty;

		/// <summary>
		/// Country of residence
		/// </summary>
		[DataMember(Name = "country_of_residence")]
		public string? CountryOfResidence { get; set; }

		/// <summary>
		/// Date of birth
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public DateOfBirth? DateOfBirth { get; set; }

		/// <summary>
		/// Former names
		/// </summary>
		[DataMember(Name = "former_names")]
		public List<FormerNames>? FormerNames { get; set; }

		/// <summary>
		/// Identification
		/// </summary>
		[DataMember(Name = "identification")]
		public Identification? Identification { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public OfficerLinks Links { get; set; } = new();

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Nationality
		/// </summary>
		[DataMember(Name = "nationality")]
		public string? Nationality { get; set; }

		/// <summary>
		/// Occupation
		/// </summary>
		[DataMember(Name = "occupation")]
		public string? Occupation { get; set; }

		/// <summary>
		/// Officer role
		/// </summary>
		[DataMember(Name = "officer_role")]
		public string OfficerRole { get; set; } = string.Empty;

		/// <summary>
		/// Resigned on
		/// </summary>
		[DataMember(Name = "resigned_on")]
		public string? ResignedOn { get; set; }
	}
}
