using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search
{

	[DataContract]
	public class Matches
	{
		/// <summary>
		/// Snippet
		/// </summary>
		[DataMember(Name = "snippet")]
		public List<object> Snippet { get; set; } = new();

		/// <summary>
		/// Title
		/// </summary>
		[DataMember(Name = "title")]
		public List<int> Title { get; set; } = new();
	}

}