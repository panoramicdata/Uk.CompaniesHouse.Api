using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Search;

/// <summary>
/// Disqualified officer search
/// </summary>
[DataContract]
public class DisqualifiedOfficerSearchResults
{
	/// <summary>
	/// The address of the disqualified officer as provided by the disqualifying authority.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();

	/// <summary>
	/// A single line address.
	/// </summary>
	[DataMember(Name = "address_snippet")]
	public string AddressSnippet { get; set; } = string.Empty;

	/// <summary>
	/// The result description.
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }

	/// <summary>
	/// An array of enumeration types that make up the search description.
	/// </summary>
	[DataMember(Name = "description_identifier")]
	public List<string>? DescriptionIdentifier { get; set; }

	/// <summary>
	/// Describes the type of result returned.
	/// </summary>
	[DataMember(Name = "kind")]
	public string Kind { get; set; } = string.Empty;

	/// <summary>
	/// The URL of the search result.
	/// </summary>
	[DataMember(Name = "links")]
	public Links Links { get; set; } = new();

	/// <summary>
	/// A list of members and arrays of character offset defining substrings that matched the search terms.
	/// </summary>
	[DataMember(Name = "matches")]
	public Matches? Matches { get; set; }

	/// <summary>
	/// Summary information for the result showing additional details that have matched.
	/// </summary>
	[DataMember(Name = "snippet")]
	public string? Snippet { get; set; }

	/// <summary>
	/// The title of the search result.
	/// </summary>
	[DataMember(Name = "title")]
	public string Title { get; set; } = string.Empty;

	/// <summary>
	/// The disqualified officer's date of birth.
	/// </summary>
	[DataMember(Name = "date_of_birth")]
	public DateOfBirth? DateOfBirth { get; set; }
}
