using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

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
		/// The result description.
		/// </summary>
		[DataMember(Name = "description_identifier")]
		public List<string> DescriptionIdentifier { get; set; } = new();

		/// <summary>
		/// The title of the search result.
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; } = null!;

		/// <summary>
		/// The company type.
		/// </summary>
		[DataMember(Name = "company_type")]
		public string CompanyType { get; set; } = null!;

		/// <summary>
		/// The address of the company's registered office.
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// The date the company was created.
		/// </summary>
		[DataMember(Name = "date_of_creation")]
		public string CreationDate { get; set; } = null!;

		/// <summary>
		/// The result description.
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = null!;

		/// <summary>
		/// A single line address.
		/// </summary>
		[DataMember(Name = "address_snippet")]
		public string AddressSnippet { get; set; } = null!;

		/// <summary>
		/// The type of search result.
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = null!;

		/// <summary>
		/// The company status.
		/// </summary>
		[DataMember(Name = "company_status")]
		public string CompanyStatus { get; set; } = null!;

		/// <summary>
		/// The company registration / incorporation number of the company.
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = null!;

		/// <summary>
		/// The URL of the search result.
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// A list of members and arrays of character offset defining substrings that matched the search terms.
		/// </summary>
		[DataMember(Name = "matches")]
		public Matches Matches { get; set; } = new();
	}
}