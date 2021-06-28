using Refit;
using System.Threading;
using System.Threading.Tasks;
using Uk.CompaniesHouse.Api.Data.Appointment;
using Uk.CompaniesHouse.Api.Data.Charges;
using Uk.CompaniesHouse.Api.Data.Common;
using Uk.CompaniesHouse.Api.Data.Company;
using Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural;
using Uk.CompaniesHouse.Api.Data.Exemptions;
using Uk.CompaniesHouse.Api.Data.Insolvency;
using Uk.CompaniesHouse.Api.Data.Person_with_Significant_Control;
using Uk.CompaniesHouse.Api.Data.Search;

namespace Uk.CompaniesHouse.Api.Interfaces
{
	public interface ICompany
	{
		/// <summary>
		/// Find company information from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}")]
		public Task<Company> GetByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find address information from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/registered-address")]
		public Task<Address> GetRegisteredAddressAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find officer information from the appointment number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/appointments/{appointmentNumber}")]
		public Task<Appointment> GetOfficerInformationAppointmentAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken,
			[AliasAs("appointmentNumber")] string appointmentNumber
			);

		/// <summary>
		/// Find filing history from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/filing-history")]
		public Task<Page<FilingHistory>> GetFilingHistoryByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find details of person(s) with significant control from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/persons-with-significant-control")]
		public Task<Page<PersonWithSignificantControl>> GetPWSCInfoByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find details of disqualified officer from officer ID
		/// </summary>
		/// <param name="officerID">The officer ID</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/disqualified-officers/natural/{officer_id}")]
		public Task<DisqualifiedOfficerNatural> GetNaturalDisqualifiedByIdAsync(
			[AliasAs("officer_id")] string officerID,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find details of charges from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/charges")]
		public Task<Page<Charges>> GetChargesByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find details of insolvency from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/insolvency")]
		public Task<InsolvencyMain> GetInsolvencyByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find details of exemptions from the company number
		/// </summary>
		/// <param name="companyNumber">The company number</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/company/{companyNumber}/exemptions")]
		public Task<ExemptionsMain> GetExemptionsByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);
	}
}