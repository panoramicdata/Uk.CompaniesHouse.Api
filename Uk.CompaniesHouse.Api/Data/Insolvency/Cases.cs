using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Insolvency
{
	/// <summary>
	/// Cases
	/// </summary>
	[DataContract]
	public class Cases
	{
		///<summary>
		/// Practitioners
		/// </summary>
		[DataMember(Name = "practitioners")]
		public List<Practitioners> Practitioners { get; set; } = new();

		///<summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		///<summary>
		/// Number
		/// </summary>
		[DataMember(Name = "number")]
		public string Number { get; set; } = string.Empty;

		///<summary>
		/// Dates
		/// </summary>
		[DataMember(Name = "dates")]
		public List<Dates> Dates { get; set; } = new();

		///<summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();
	}
}
