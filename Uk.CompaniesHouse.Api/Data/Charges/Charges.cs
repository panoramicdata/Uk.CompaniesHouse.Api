using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Charges list
	/// </summary>
	[DataContract]
	public class Charges
	{
		/// <summary>
		/// Acquired on
		/// </summary>
		[DataMember(Name = "acquired_on")]
		public string? AcquiredOn { get; set; }

		/// <summary>
		/// Assets ceased released
		/// </summary>
		[DataMember(Name = "assests_ceased_released")]
		public string? AssetsCeasedReleased { get; set; }

		///<summary>
		/// Charge number
		/// </summary>
		[DataMember(Name = "charge_number")]
		public int ChargeNumber { get; set; } = 0;

		///<summary>
		/// Classification
		/// </summary>
		[DataMember(Name = "classification")]
		public List<Classification> Classification { get; set; } = new();

		/// <summary>
		/// Covering instrument date
		/// </summary>
		[DataMember(Name = "covering_instrument_date")]
		public string? CoveringInstrumentDate { get; set; }

		///<summary>
		/// Created on
		/// </summary>
		[DataMember(Name = "created_on")]
		public string? CreatedOn { get; set; }

		///<summary>
		/// Delivered on
		/// </summary>
		[DataMember(Name = "delivered_on")]
		public string? DeliveredOn { get; set; }

		///<summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		/// <summary>
		/// ID
		/// </summary>
		[DataMember(Name = "id")]
		public string? ID { get; set; }

		/// <summary>
		/// Insolvency cases
		/// </summary>
		[DataMember(Name = "insolvency_cases")]
		public List<InsolvencyCases>? InsolvencyCases { get; set; }

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links? Links { get; set; }

		/// <summary>
		/// More than four persons entitled?
		/// </summary>
		[DataMember(Name = "more_than_four_persons_entitled")]
		public bool? MoreThanFourPersonsEntitled { get; set; }

		///<summary>
		/// Particulars
		/// </summary>
		[DataMember(Name = "particulars")]
		public Particulars? Particulars { get; set; }

		/// <summary>
		///	Persons entitled
		/// </summary>
		[DataMember(Name = "persons_entitled")]
		public List<PersonsEntitled>? PersonsEntitled { get; set; }

		/// <summary>
		/// Resolved on
		/// </summary>
		[DataMember(Name = "resolved_on")]
		public string? ResolvedOn { get; set; }

		///<summary>
		/// Satisfied on
		/// </summary>
		[DataMember(Name = "satisfied_on")]
		public string? SatisfiedOn { get; set; }

		/// <summary>
		/// Scottish alterations
		/// </summary>
		[DataMember(Name = "scottish_alterations")]
		public List<ScottishAlterations>? ScottishAlterations { get; set; }

		/// <summary>
		/// Secured details
		/// </summary>
		[DataMember(Name = "secured_details")]
		public List<SecuredDetails>? SecuredDetails { get; set; }

		///<summary>
		/// Status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		///<summary>
		///	Transactions list
		/// </summary>
		[DataMember(Name = "transactions")]
		public List<Transactions>? Transactions { get; set; }
	}
}
