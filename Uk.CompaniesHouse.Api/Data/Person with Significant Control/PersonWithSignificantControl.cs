using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Person_with_Significant_Control
{
	/// <summary>
	/// Person with significant control
	/// </summary>
	[DataContract]
	public class PersonWithSignificantControl
	{
		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name_elements")]
		public NameElements NameElements { get; set; } = new();

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public PersonWithSignificantControlLinks Links { get; set; } = new();

		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Country of residence
		/// </summary>
		[DataMember(Name = "country_of_residence")]
		public string CountryOfResidence { get; set; } = string.Empty;

		/// <summary>
		/// Notified on
		/// </summary>
		[DataMember(Name = "notified_on")]
		public string NotifiedOn { get; set; } = string.Empty;

		/// <summary>
		/// Natures of control
		/// </summary>
		[DataMember(Name = "natures_of_control")]
		public List<string> NaturesOfControl { get; set; } = new();

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Nationality
		/// </summary>
		[DataMember(Name = "nationality")]
		public string Nationality { get; set; } = string.Empty;

		/// <summary>
		/// Date of birth
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public DateOfBirth DateOfBirth { get; set; } = new();
	}
}
