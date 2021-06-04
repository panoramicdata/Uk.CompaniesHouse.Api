using Refit;
using System.Threading;
using System.Threading.Tasks;
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
		public Task<CompanySearchResult> GetByIdAsync(
			[AliasAs("companyNumber")] string companyNumber,
			CancellationToken cancellationToken
			);
	}
}