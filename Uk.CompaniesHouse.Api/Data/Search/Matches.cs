using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search
{
	[DataContract]
	public class Matches
	{
		/// <summary>
		/// Address snippet
		/// </summary>
		[DataMember(Name = "address_snippet")]
		public List<int>? AddressSnippet { get; set; }

		/// <summary>
		/// Snippet
		/// </summary>
		[DataMember(Name = "snippet")]
		public List<int>? Snippet { get; set; }

		/// <summary>
		/// Title
		/// </summary>
		[DataMember(Name = "title")]
		public List<int>? Title { get; set; }
	}
}