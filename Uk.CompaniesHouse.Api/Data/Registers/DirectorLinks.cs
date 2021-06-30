using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Links
	/// </summary>
	[DataContract]
	public class DirectorLinks
	{
		/// <summary>
		/// Directors register
		/// </summary>
		[DataMember(Name = "directors_register")]
		public string? DirectorsRegister { get; set; }
	}
}
