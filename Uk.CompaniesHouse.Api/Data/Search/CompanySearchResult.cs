using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;
using Uk.CompaniesHouse.Api.Data.Company;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	/// <summary>
	/// Company information
	/// </summary>
	[DataContract]
	[DebuggerDisplay("{Title}")]
	public class CompanySearchResult
	{
		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description_identifier")]
		public List<string> DescriptionIdentifier { get; set; } = new();

		/// <summary>
		/// Title
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; } = null!;

		/// <summary>
		/// Company type
		/// </summary>
		[DataMember(Name = "company_type")]
		public string CompanyType { get; set; } = null!;

		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Creation date
		/// </summary>
		[DataMember(Name = "date_of_creation")]
		public string CreationDate { get; set; } = null!;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = null!;

		/// <summary>
		/// Address snippet
		/// </summary>
		[DataMember(Name = "address_snippet")]
		public string AddressSnippet { get; set; } = null!;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = null!;

		/// <summary>
		/// Company status
		/// </summary>
		[DataMember(Name = "company_status")]
		public string CompanyStatus { get; set; } = null!;

		/// <summary>
		/// Company number
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = null!;

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public CompanyLinks Links { get; set; } = new();

		/// <summary>
		/// Matches
		/// </summary>
		[DataMember(Name = "matches")]
		public Matches Matches { get; set; } = new();
	}
}