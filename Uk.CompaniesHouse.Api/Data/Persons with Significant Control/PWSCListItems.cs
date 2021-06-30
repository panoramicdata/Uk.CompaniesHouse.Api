using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Items
	/// </summary>
	[DataContract]
	public class PWSCListItems
	{
		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Ceased
		/// </summary>
		[DataMember(Name = "ceased")]
		public bool? Ceased { get; set; }

		/// <summary>
		/// Ceased on
		/// </summary>
		[DataMember(Name = "ceased_on")]
		public string? CeasedOn { get; set; }

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
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string? Description { get; set; }

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Identification
		/// </summary>
		[DataMember(Name = "identification")]
		public CorporateIdentification? Identification { get; set; }

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string? Kind { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public PWSCLinks Links { get; set; } = new();

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Name elements
		/// </summary>
		[DataMember(Name = "name_elements")]
		public NameElements? NameElements { get; set; }

		/// <summary>
		/// Nationality
		/// </summary>
		[DataMember(Name = "nationality")]
		public string? Nationality { get; set; }

		/// <summary>
		/// Natures of control
		/// </summary>
		[DataMember(Name = "natures_of_control")]
		public List<Object> NaturesOfControl { get; set; } = new();

		/// <summary>
		/// Notified on
		/// </summary>
		[DataMember(Name = "notified_on")]
		public string NotifiedOn { get; set; } = string.Empty;
	}
}
