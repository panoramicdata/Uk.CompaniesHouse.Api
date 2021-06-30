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
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Ceased on
		/// </summary>
		[DataMember(Name = "ceased_on")]
		public string? CeasedOn { get; set; }

		/// <summary>
		/// Etag
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
