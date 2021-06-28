using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	/// <summary>
	/// Officer details from search
	/// </summary>
	[DataContract]
	[DebuggerDisplay("{Title}")]
	public class OfficerSearchResult
	{
		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Description identifiers
		/// </summary>
		[DataMember(Name = "description_identifiers")]
		public List<string> DescriptionIdentifiers { get; set; } = new();

		/// <summary>
		/// Full title
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = null!;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = null!;

		/// <summary>
		/// Matches
		/// </summary>
		[DataMember(Name = "matches")]
		public Matches Matches { get; set; } = new();

		/// <summary>
		/// Date of birth
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public DateOfBirth DateOfBirth { get; set; } = new();

		/// <summary>
		/// Full title
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// Address snippet
		/// </summary>
		[DataMember(Name = "address_snippet")]
		public string AddressSnippet { get; set; } = null!;
	}
}
