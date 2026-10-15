using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// Base PSC resource shared by <see cref="CorporateEntity"/> and <see cref="LegalPerson"/>:
/// the properties common to every person with significant control, in one place.
/// </summary>
public abstract class PscResource<TLinks, TIdentification> where TLinks : new() where TIdentification : new()
{
	/// <summary>
	/// The date that Companies House was notified about the cessation of this person with significant control.
	/// </summary>
	[DataMember(Name = "ceased_on")]
	public string? CeasedOn { get; set; }

	/// <summary>
	/// The ETag of the resource.
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// Kind
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// A set of URLs related to the resource, including self.
	/// </summary>
	[DataMember(Name = "links")]
	public TLinks Links { get; set; } = new();

	/// <summary>
	/// Name of the person with significant control.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

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

/// <summary>
/// Identification common to persons with significant control that have one,
/// in one place.
/// </summary>
public abstract class PscWithIdentification<TIdentification> : PscResource<PWSCLinks, TIdentification>
	where TIdentification : new()
{
	/// <summary>
	/// Identification
	/// </summary>
	[DataMember(Name = "identification")]
	public TIdentification Identification { get; set; } = new();
}

/// <summary>
/// Corporate entity
/// </summary>
[DataContract]
public class CorporateEntity : PscWithIdentification<CorporateIdentification>
{
	/// <summary>
	/// The address of the person with significant control.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();
}
