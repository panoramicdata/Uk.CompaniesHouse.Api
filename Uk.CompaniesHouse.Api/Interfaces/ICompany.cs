using Refit;
using System.Threading;
using System.Threading.Tasks;
using Uk.CompaniesHouse.Api.Data.Appointment;
using Uk.CompaniesHouse.Api.Data.Common;
using Uk.CompaniesHouse.Api.Data.Company;
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
	}
}