using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Registers
	/// </summary>
	[DataContract]
	public class Registers
	{
		/// <summary>
		/// Directors
		/// </summary>
		[DataMember(Name = "directors")]
		public Directors Directors { get; set; } = new();

		/// <summary>
		/// LLP members
		/// </summary>
		[DataMember(Name = "llp_members")]
		public LlpMembers LlpMembers { get; set; } = new();

		/// <summary>
		/// LLP usual residential address
		/// </summary>
		[DataMember(Name = "llp_usual_residential_address")]
		public LlpUsualResidentialAddress? LlpUsualResidentialAddress { get; set; }

		/// <summary>
		/// Members
		/// </summary>
		[DataMember(Name = "members")]
		public Members Members { get; set; } = new();

		/// <summary>
		/// Persons with significant control
		/// </summary>
		[DataMember(Name = "persons_with_significant_control")]
		public PersonsWithSignificantControl PersonsWithSignificantControl { get; set; } = new();

		/// <summary>
		/// Secretaries
		/// </summary>
		[DataMember(Name = "secretaries")]
		public Secretaries Secretaries { get; set; } = new();

		/// <summary>
		/// Usual residential address
		/// </summary>
		[DataMember(Name = "usual_residential_address")]
		public UsualResidentialAddress UsualResidentialAddress { get; set; } = new();
	}
}
