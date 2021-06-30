using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	/// <summary>
	/// Disqualified officer search
	/// </summary>
	[DataContract]
	public class DisqualifiedOfficerSearchResults
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
		/// Company number
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = string.Empty;

		/// <summary>
		/// Company status
		/// </summary>
		[DataMember(Name = "company_status")]
		public string CompanyStatus { get; set; } = string.Empty;

		/// <summary>
		/// Company type
		/// </summary>
		[DataMember(Name = "company_type")]
		public string CompanyType { get; set; } = string.Empty;

		/// <summary>
		/// Date of cessation
		/// </summary>
		[DataMember(Name = "date_of_cessation")]
		public string? DateOfCessation { get; set; }

		/// <summary>
		/// Date of creation
		/// </summary>
		[DataMember(Name = "date_of_creation")]
		public string DateOfCreation { get; set; } = string.Empty;

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
