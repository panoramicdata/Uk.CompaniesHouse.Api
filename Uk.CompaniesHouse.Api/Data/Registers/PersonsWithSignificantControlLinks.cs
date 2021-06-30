using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class PersonsWithSignificantControlLinks
	{
		/// <summary>
		/// Persons with significant control links
		/// </summary>
		[DataMember(Name = "persons_with_significant_control_register")]
		public string? PersonsWithSignificantControlRegister { get; set; }
	}
}
