using Refit;
using System.Threading;
using System.Threading.Tasks;
using Uk.CompaniesHouse.Api.Data.Search;

namespace Uk.CompaniesHouse.Api.Interfaces
{
	public interface ISearch
	{
		/// <summary>
		/// Find information from name
		/// </summary>
		/// <param name="query">The query string</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/search")]
		public Task<Page<OverallSearch>> GetInfoByNameAsync(
			[AliasAs("q")] string query,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find company information from the company name
		/// </summary>
		/// <param name="query">The query string</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/search/companies")]
		public Task<Page<CompanySearchResult>> GetCompanyInfoByNameAsync(
			[AliasAs("q")] string query,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find officer information from the officer name
		/// </summary>
		/// <param name="query">The query string</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/search/officers")]
		public Task<Page<OfficerSearchResult>> GetOfficerInfoByNameAsync(
			[AliasAs("q")] string query,
			CancellationToken cancellationToken
			);

		/// <summary>
		/// Find officer information from the officer name
		/// </summary>
		/// <param name="query">The query string</param>
		/// <param name="cancellationToken">The cancellation token</param>
		[Get("/search/officers")]
		public Task<Page<DisqualifiedOfficerSearchResults>> GetDisqualifiedOfficerInfoByNameAsync(
			[AliasAs("q")] string query,
			CancellationToken cancellationToken
			);
	}
}