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
		/// The correspondence address of the officer.
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// The date on which the officer was appointed.
		/// </summary>
		[DataMember(Name = "appointed_on")]
		public string AppointedOn { get; set; } = string.Empty;

		/// <summary>
		/// The officer's country of residence.
		/// </summary>
		[DataMember(Name = "country_of_residence")]
		public string? CountryOfResidence { get; set; }

		/// <summary>
		/// Details of director date of birth.
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public DateOfBirth? DateOfBirth { get; set; }

		/// <summary>
		/// Former names for the officer.
		/// </summary>
		[DataMember(Name = "former_names")]
		public List<FormerNames>? FormerNames { get; set; }

		/// <summary>
		/// Identification
		/// </summary>
		[DataMember(Name = "identification")]
		public Identification? Identification { get; set; }

		/// <summary>
		/// Links to other resources associated with this officer list item.
		/// </summary>
		[DataMember(Name = "links")]
		public OfficerLinks Links { get; set; } = new();

		/// <summary>
		/// Corporate or natural officer name.
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// The officer's nationality.
		/// </summary>
		[DataMember(Name = "nationality")]
		public string? Nationality { get; set; }

		/// <summary>
		/// The officer's job title.
		/// </summary>
		[DataMember(Name = "occupation")]
		public string? Occupation { get; set; }

		/// <summary>
		/// Officer role
		/// </summary>
		[DataMember(Name = "officer_role")]
		public string OfficerRole { get; set; } = string.Empty;

		/// <summary>
		/// The date on which the officer resigned.
		/// </summary>
		[DataMember(Name = "resigned_on")]
		public string? ResignedOn { get; set; }
	}
}
