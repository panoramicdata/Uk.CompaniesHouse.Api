using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers;

/// <summary>
/// Registers
/// </summary>
[DataContract]
public class Registers
{
	/// <summary>
	/// List of registered company directors.
	/// </summary>
	[DataMember(Name = "directors")]
	public Directors Directors { get; set; } = new();

	/// <summary>
	/// List of registered llp members.
	/// </summary>
	[DataMember(Name = "llp_members")]
	public LlpMembers LlpMembers { get; set; } = new();

	/// <summary>
	/// List of register addresses.
	/// </summary>
	[DataMember(Name = "llp_usual_residential_address")]
	public LlpUsualResidentialAddress? LlpUsualResidentialAddress { get; set; }

	/// <summary>
	/// List of registered company members.
	/// </summary>
	[DataMember(Name = "members")]
	public Members Members { get; set; } = new();

	/// <summary>
	/// List of registered company persons with significant control.
	/// </summary>
	[DataMember(Name = "persons_with_significant_control")]
	public PersonsWithSignificantControl PersonsWithSignificantControl { get; set; } = new();

	/// <summary>
	/// List of registered company secretaries.
	/// </summary>
	[DataMember(Name = "secretaries")]
	public Secretaries Secretaries { get; set; } = new();

	/// <summary>
	/// List of register addresses.
	/// </summary>
	[DataMember(Name = "usual_residential_address")]
	public UsualResidentialAddress UsualResidentialAddress { get; set; } = new();
}
