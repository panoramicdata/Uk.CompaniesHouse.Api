using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search
{

	[DataContract]
	public class Links
	{

		[DataMember(Name = "self")]
		public string Self { get; set; } = string.Empty;
	}

}