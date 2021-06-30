using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Uk.CompaniesHouse.Api.Data.Common;

namespace Uk.CompaniesHouse.Api.Data.Registers
{
	/// <summary>
	/// Registers
	/// </summary>
	[DataContract]
	public class RegistersMain
	{
		/// <summary>
		/// Company number
		/// </summary>
		[DataMember(Name = "company_number")]
		public string CompanyNumber { get; set; } = string.Empty;

		/// <summary>
		/// Etag
		/// </summary>
		[DataMember(Name = "etag")]
		public string? Etag { get; set; }

		/// <summary>
		/// Kind
		/// </summary>
		[DataMember(Name = "kind")]
		public string Kind { get; set; } = string.Empty;

		/// <summary>
		/// Links
		/// </summary>
		[DataMember(Name = "links")]
		public Links Links { get; set; } = new();

		/// <summary>
		/// Registers
		/// </summary>
		[DataMember(Name = "registers")]
		public Registers Registers { get; set; } = new();
	}
}
