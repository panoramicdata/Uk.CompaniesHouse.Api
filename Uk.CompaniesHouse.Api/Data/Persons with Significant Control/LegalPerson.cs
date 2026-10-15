using System;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;

/// <summary>
/// Legal person
/// </summary>
[DataContract]
public class LegalPerson : PscWithIdentification<LegalPersonIdentification>
{
	/// <summary>
	/// The address of the person with significant control.
	/// </summary>
	[DataMember(Name = "address")]
	public Address Address { get; set; } = new();
}
