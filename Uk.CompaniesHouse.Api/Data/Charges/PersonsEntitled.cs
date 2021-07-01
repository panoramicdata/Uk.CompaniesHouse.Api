using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// People that are entitled to the charge
	/// </summary>
	[DataContract]
	public class PersonsEntitled
	{
		/// <summary>
		/// The name of the person entitled.
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}
