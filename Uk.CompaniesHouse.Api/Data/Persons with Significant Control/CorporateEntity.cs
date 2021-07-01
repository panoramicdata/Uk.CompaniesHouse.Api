using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control
{
	/// <summary>
	/// Corporate entity
	/// </summary>
	[DataContract]
	public class CorporateEntity
	{
		/// <summary>
		/// The address of the person with significant control.
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

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
		/// Identification
		/// </summary>
		[DataMember(Name = "identification")]
		public CorporateIdentification Identification { get; set; } = new();

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

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
		/// Indicates the nature of control the person with significant control holds.
		/// </summary>
		[DataMember(Name = "natures_of_control")]
		public List<Object> NaturesOfControl { get; set; } = new();

		/// <summary>
		/// The date that Companies House was notified about this person with significant control.
		/// </summary>
		[DataMember(Name = "notified_on")]
		public string NotifiedOn { get; set; } = string.Empty;
	}
}
