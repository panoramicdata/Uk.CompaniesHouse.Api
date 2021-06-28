using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural
{
	/// <summary>
	/// Disqualified officer details
	/// </summary>
	[DataContract]
	public class DisqualifiedOfficerNatural
	{
		/// <summary>
		/// List of disqualifications
		/// </summary>
		[DataMember(Name = "disqualifications")]
		public List<Disqualifications> Disqualifications { get; set; } = new();

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		///	Nationality
		/// </summary>
		[DataMember(Name = "nationality")]
		public string Nationality { get; set; } = string.Empty;

		/// <summary>
		/// Forename
		/// </summary>
		[DataMember(Name = "forename")]
		public string Forename { get; set; } = string.Empty;

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// Surname
		/// </summary>
		[DataMember(Name = "surname")]
		public string Surname { get; set; } = string.Empty;

		/// <summary>
		/// Date of birth
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public string DateOfBirth { get; set; } = string.Empty;
	}
}
