using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// The list of persons with significant control.
/// </summary>
[DataContract]
public class PWSCListItems
{
	/// <summary>
	/// The service address of the person with significant control. If given, this address will be shown on the public record instead of the residential address.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();

	/// <summary>
	/// Presence of that indicator means the super secure person status is ceased
	/// </summary>
	[DataMember(Name = "ceased")]
	public bool? Ceased { get; set; }

	/// <summary>
	/// The date that Companies House was notified about the cessation of this person with significant control.
	/// </summary>
	[DataMember(Name = "ceased_on")]
	public string? CeasedOn { get; set; }

	/// <summary>
	/// The country of residence of the person with significant control.
	/// </summary>
	[DataMember(Name = "country_of_residence")]
	public string? CountryOfResidence { get; set; }

	/// <summary>
	/// The date of birth of the person with significant control.
	/// </summary>
	[DataMember(Name = "date_of_birth")]
	public DateOfBirth? DateOfBirth { get; set; }

	/// <summary>
	/// Description of the super secure legal statement
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// The ETag of the resource.
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
	/// A set of URLs related to the resource, including self.
	/// </summary>
	[DataMember(Name = "links")]
	public PWSCLinks Links { get; set; } = new();

	/// <summary>
	/// Name of the person with significant control.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// A document encapsulating the separate elements of a person with significant control's name.
	/// </summary>
	[DataMember(Name = "name_elements")]
	public NameElements? NameElements { get; set; }

	/// <summary>
	/// The nationality of the person with significant control.
	/// </summary>
	[DataMember(Name = "nationality")]
	public string? Nationality { get; set; }

	/// <summary>
	/// Indicates the nature of control the person with significant control holds.
	/// </summary>
	[DataMember(Name = "natures_of_control")]
	public List<Object> NaturesOfControl { get; set; } = [];

	/// <summary>
	/// The date that Companies House was notified about this person with significant control.
	/// </summary>
	[DataMember(Name = "notified_on")]
	public string NotifiedOn { get; set; } = string.Empty;
}
