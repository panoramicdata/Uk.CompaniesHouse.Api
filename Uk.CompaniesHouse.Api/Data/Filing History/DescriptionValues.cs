using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Filing_History;

/// <summary>
/// Description values
/// </summary>
[DataContract]
public class DescriptionValues
{
	/// <summary>
	/// Made up date
	/// </summary>
	[DataMember(Name = "made_up_date")]
	public string MadeUpDate { get; set; } = string.Empty;
}