using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Insolvency
{
	/// <summary>
	/// Practitioners
	/// </summary>
	[DataContract]
	public class Practitioners
	{
		///<summary>
		/// Address
		/// </summary>
		[DataMember(Name = "address")]
		public Address Address { get; set; } = new();

		///<summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		///<summary>
		/// Role
		/// </summary>
		[DataMember(Name = "role")]
		public string Role { get; set; } = string.Empty;

		///<summary>
		/// Ceased to act on
		/// </summary>
		[DataMember(Name = "ceased_to_act_on")]
		public string CeasedToActOn { get; set; } = string.Empty;

		///<summary>
		/// Appointed on
		/// </summary>
		[DataMember(Name = "appointed_on")]
		public string AppointedOn { get; set; } = string.Empty;
	}
}
