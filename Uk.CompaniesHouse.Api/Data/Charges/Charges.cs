using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Charges;

/// <summary>
/// Charges list
/// </summary>
[DataContract]
public class Charges
{
	/// <summary>
	/// The date the property or undertaking was acquired on
	/// </summary>
	[DataMember(Name = "acquired_on")]
	public string? AcquiredOn { get; set; }

	/// <summary>
	/// Cease/release information about the charge.
	/// </summary>
	[DataMember(Name = "assests_ceased_released")]
	public string? AssetsCeasedReleased { get; set; }

	/// <summary>
	/// The charge code is a replacement of the mortgage description
	/// </summary>
	[DataMember(Name = "charge_code")]
	public string? ChargeCode { get; set; }

	///<summary>
	/// The charge number is used to reference an individual charge
	/// </summary>
	[DataMember(Name = "charge_number")]
	public int ChargeNumber { get; set; }

	///<summary>
	/// Classification information
	/// </summary>
	[DataMember(Name = "classification")]
	public List<Classification> Classification { get; set; } = [];

	/// <summary>
	/// The date by which the series of debentures were created
	/// </summary>
	[DataMember(Name = "covering_instrument_date")]
	public string? CoveringInstrumentDate { get; set; }

	///<summary>
	/// The date the charge was created
	/// </summary>
	[DataMember(Name = "created_on")]
	public string? CreatedOn { get; set; }

	///<summary>
	/// The date the charge was submitted to Companies House
	/// </summary>
	[DataMember(Name = "delivered_on")]
	public string? DeliveredOn { get; set; }

	///<summary>
	/// Etag
	/// </summary>
	[DataMember(Name = "etag")]
	public string Etag { get; set; } = string.Empty;

	/// <summary>
	/// The id of the charge
	/// </summary>
	[DataMember(Name = "id")]
	public string? ID { get; set; }

	/// <summary>
	/// Transactions that have been filed for the charge.
	/// </summary>
	[DataMember(Name = "insolvency_cases")]
	public List<InsolvencyCases>? InsolvencyCases { get; set; }

	/// <summary>
	/// The resources related to this charge
	/// </summary>
	[DataMember(Name = "links")]
	public Links? Links { get; set; }

	/// <summary>
	/// Charge has more than four person entitled
	/// </summary>
	[DataMember(Name = "more_than_four_persons_entitled")]
	public bool? MoreThanFourPersonsEntitled { get; set; }

	///<summary>
	/// Details of charge or undertaking
	/// </summary>
	[DataMember(Name = "particulars")]
	public Particulars? Particulars { get; set; }

	/// <summary>
	///	People that are entitled to the charge
	/// </summary>
	[DataMember(Name = "persons_entitled")]
	public List<PersonsEntitled>? PersonsEntitled { get; set; }

	/// <summary>
	/// The date the issue was resolved on
	/// </summary>
	[DataMember(Name = "resolved_on")]
	public string? ResolvedOn { get; set; }

	///<summary>
	/// The date the charge was satisfied
	/// </summary>
	[DataMember(Name = "satisfied_on")]
	public string? SatisfiedOn { get; set; }

	/// <summary>
	///  Information about alterations for Scottish companies
	/// </summary>
	[DataMember(Name = "scottish_alterations")]
	public List<ScottishAlterations>? ScottishAlterations { get; set; }

	/// <summary>
	/// Information about what is secured against this charge
	/// </summary>
	[DataMember(Name = "secured_details")]
	public List<SecuredDetails>? SecuredDetails { get; set; }

	///<summary>
	/// The status of the charge.
	/// </summary>
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	///<summary>
	///	Transactions that have been filed for the charge.
	/// </summary>
	[DataMember(Name = "transactions")]
	public List<Transactions>? Transactions { get; set; }
}
