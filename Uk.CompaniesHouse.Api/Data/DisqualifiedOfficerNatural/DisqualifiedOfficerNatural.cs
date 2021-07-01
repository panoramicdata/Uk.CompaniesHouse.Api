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
		/// The officer's disqualifications.
		/// </summary>
		[DataMember(Name = "disqualifications")]
		public List<Disqualifications> Disqualifications { get; set; } = new();

		/// <summary>
		/// Links to other resources associated with this officer disqualification resource.
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		///	The nationality of the disqualified officer.
		/// </summary>
		[DataMember(Name = "nationality")]
		public string? Nationality { get; set; }

		/// <summary>
		/// The forename of the disqualified officer.
		/// </summary>
		[DataMember(Name = "forename")]
		public string? Forename { get; set; }

		/// <summary>
		/// The other forenames of the disqualified officer.
		/// </summary>
		[DataMember(Name = "other_forenames")]
		public string? OtherForenames { get; set; }

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// The ETag of the resource.
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// The surname of the disqualified officer.
		/// </summary>
		[DataMember(Name = "surname")]
		public string Surname { get; set; } = string.Empty;

		/// <summary>
		/// The title of the disqualified officer.
		/// </summary>
		[DataMember(Name = "title")]
		public string? Title { get; set; }

		/// <summary>
		/// The disqualified officer's date of birth.
		/// </summary>
		[DataMember(Name = "date_of_birth")]
		public string? DateOfBirth { get; set; }

		/// <summary>
		/// The honours that the disqualified officer has.
		/// </summary>
		[DataMember(Name = "honours")]
		public string? Honours { get; set; }

		/// <summary>
		/// Permissions to act that have been granted for the disqualified officer.
		/// </summary>
		[DataMember(Name = "permissions_to_act")]
		public List<PermissionsToAct>? PermissionsToAct { get; set; }
	}
}
