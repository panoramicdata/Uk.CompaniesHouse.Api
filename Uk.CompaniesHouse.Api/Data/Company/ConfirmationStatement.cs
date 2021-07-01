using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company
{
	/// <summary>
	/// Confirmation statement information.
	/// </summary>
	[DataContract]
	public class ConfirmationStatement
	{
		/// <summary>
		/// The date by which the next confirmation statement must be received.
		/// </summary>
		[DataMember(Name = "next_due")]
		public string NextDue { get; set; } = string.Empty;

		/// <summary>
		/// The date to which the company must next make a confirmation statement.
		/// </summary>
		[DataMember(Name = "next_made_up_to")]
		public string NextMadeUpTo { get; set; } = string.Empty;

		/// <summary>
		/// The date to which the company last made a confirmation statement.
		/// </summary>
		[DataMember(Name = "last_made_up_to")]
		public string LastMadeUpTo { get; set; } = string.Empty;

		/// <summary>
		/// Flag indicating if the confirmation statement is overdue
		/// </summary>
		[DataMember(Name = "overdue")]
		public bool Overdue { get; set; }
	}
}
