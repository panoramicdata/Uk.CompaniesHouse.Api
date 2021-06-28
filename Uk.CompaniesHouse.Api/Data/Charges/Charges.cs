using System.Collections.Generic;
using System.Runtime.Serialization;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Charges
{
	/// <summary>
	/// Charges
	/// </summary>
	[DataContract]
	public class Charges
	{
		/// <summary>
		///	Persons entitled
		/// </summary>
		[DataMember(Name = "persons_entitled")]
		public List<PersonsEntitled> PersonsEntitled { get; set; } = new();

		///<summary>
		///	Transactions list
		/// </summary>
		[DataMember(Name = "transactions")]
		public List<Transactions> Transactions { get; set; } = new();

		///<summary>
		/// Classification
		/// </summary>
		[DataMember(Name = "classification")]
		public Classification Classification { get; set; } = new();

		///<summary>
		/// Particulars
		/// </summary>
		[DataMember(Name = "particulars")]
		public Particulars Particulars { get; set; } = new();

		///<summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string Etag { get; set; } = string.Empty;

		///<summary>
		/// Charge number
		/// </summary>
		[DataMember(Name = "charge_number")]
		public int ChargeNumber { get; set; } = 0;

		///<summary>
		/// Status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		///<summary>
		/// Created on
		/// </summary>
		[DataMember(Name = "created_on")]
		public string CreatedOn { get; set; } = string.Empty;

		///<summary>
		/// Charge code
		/// </summary>
		[DataMember(Name = "charge_code")]
		public string ChargeCode { get; set; } = string.Empty;

		///<summary>
		/// Delivered on
		/// </summary>
		[DataMember(Name = "delivered_on")]
		public string DeliveredOn { get; set; } = string.Empty;

		///<summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		///<summary>
		/// Satisfied on
		/// </summary>
		[DataMember(Name = "satisfied_on")]
		public string SatisfiedOn { get; set; } = string.Empty;
	}
}
