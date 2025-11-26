using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Company;

/// <summary>
/// Must file within
/// </summary>
[DataContract]
public class MustFileWithin
{
	/// <summary>
	/// Number of months within which to file.
	/// </summary>
	[DataMember(Name = "months")]
	public int? Type { get; set; }
}
