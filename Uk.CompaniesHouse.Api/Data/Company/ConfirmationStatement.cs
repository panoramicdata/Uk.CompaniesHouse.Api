using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Confirmation statement
	/// </summary>
	[DataContract]
	public class ConfirmationStatement
	{
		/// <summary>
		/// Next due
		/// </summary>
		[DataMember(Name = "next_due")]
		public string NextDue { get; set; } = string.Empty;

		/// <summary>
		/// Next made up to
		/// </summary>
		[DataMember(Name = "next_made_up_to")]
		public string NextMadeUpTo { get; set; } = string.Empty;

		/// <summary>
		/// Last made up to
		/// </summary>
		[DataMember(Name = "last_made_up_to")]
		public string LastMadeUpTo { get; set; } = string.Empty;

		/// <summary>
		/// Is it overdue?
		/// </summary>
		[DataMember(Name = "overdue")]
		public bool overdue { get; set; }
	}
}
