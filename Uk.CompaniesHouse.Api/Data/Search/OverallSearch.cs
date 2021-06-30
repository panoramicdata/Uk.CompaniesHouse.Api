using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	/// <summary>
	/// Items
	/// </summary>
	[DataContract]
	public class OverallSearch
	{
		/// <summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		/// <summary>
		/// Address snippet
		/// </summary>
		[DataMember(Name = "address_snippet")]
		public string AddressSnippet { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string? Description { get; set; }

		/// <summary>
		/// Description identifier
		/// </summary>
		[DataMember(Name = "description_identifier")]
		public List<string>? DescriptionIdentifier { get; set; }

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// Matches
		/// </summary>
		[DataMember(Name = "matches")]
		public Matches? Matches { get; set; }

		/// <summary>
		/// Snippet
		/// </summary>
		[DataMember(Name = "snippet")]
		public string? Snippet { get; set; }

		/// <summary>
		/// Title
		/// </summary>
		[DataMember(Name = "title")]
		public string Title { get; set; } = string.Empty;
	}
}
