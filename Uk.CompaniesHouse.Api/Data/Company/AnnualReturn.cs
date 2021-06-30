using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Annual return
	/// </summary>
	[DataContract]
	public class AnnualReturn
	{
		/// <summary>
		/// Last made up to
		/// </summary>
		[DataMember(Name = "last_made_up_to")]
		public string? LastMadeUpTo { get; set; }

		/// <summary>
		/// Next due
		/// </summary>
		[DataMember(Name = "next_due")]
		public string? NextDue { get; set; }

		/// <summary>
		/// Overdue?
		/// </summary>
		[DataMember(Name = "overdue")]
		public bool? Overdue { get; set; }
	}
}
