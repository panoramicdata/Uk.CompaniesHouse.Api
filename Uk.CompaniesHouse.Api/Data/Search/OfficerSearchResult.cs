using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Search;

/// <summary>
/// Officer details from search
/// </summary>
[DataContract]
[DebuggerDisplay("{Title}")]
public class OfficerSearchResult
{
	/// <summary>
	/// The service address of the officer.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();

	/// <summary>
	/// An array of enumeration types that make up the search description.
	/// </summary>
	[DataMember(Name = "description_identifiers")]
	public List<string> DescriptionIdentifiers { get; set; } = [];

	/// <summary>
	/// The title of the search result.
	/// </summary>
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// Describes the type of result returned.
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = null!;

	/// <summary>
	/// The result description.
	/// </summary>
	[DataMember(Name = "description")]
	public string Description { get; set; } = null!;

	/// <summary>
	/// A list of members and arrays of character offset defining substrings that matched the search terms.
	/// </summary>
	[DataMember(Name = "matches")]
	public Matches Matches { get; set; } = new();

	/// <summary>
	/// The officer date of birth details.
	/// </summary>
	[DataMember(Name = "date_of_birth")]
	public DateOfBirth DateOfBirth { get; set; } = new();

	/// <summary>
	/// The URL of the search result.
	/// </summary>
	[DataMember(Name = "links")]
	public Links Links { get; set; } = new();

	/// <summary>
	/// A single line address.
	/// </summary>
	[DataMember(Name = "address_snippet")]
	public string AddressSnippet { get; set; } = string.Empty;

	/// <summary>
	/// The total number of appointments the officer has.
	/// </summary>
	[DataMember(Name = "appointment_count")]
	public int AppointmentCount { get; set; }

	/// <summary>
	/// Summary information for the result showing additional details that have matched.
	/// </summary>
	[DataMember(Name = "snippet")]
	public string? Snippet { get; set; }
}
