using AwesomeAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Uk.CompaniesHouse.Api.Interfaces;
using Xunit;

namespace Uk.CompaniesHouse.Api.Test;

public class ClientInterfaceCoverageTests
{
	[Fact]
	public async Task AllInterfaceMethods_AreSupported()
	{
     var expectedMethodCount = typeof(ISearch).GetMethods().Length + typeof(ICompany).GetMethods().Length;

		var handler = new StubHttpMessageHandler(new Dictionary<string, string>
		{
			["/search?q=test"] = "{\"items\":[{}],\"total_results\":1}",
			["/search/companies?q=test"] = "{\"items\":[{}],\"total_results\":1}",
			["/search/officers?q=test"] = "{\"items\":[{}],\"total_results\":1}",
			["/search/disqualified-officers?q=test"] = "{\"items\":[{}],\"total_results\":1}",
			["/company/00000006"] = "{}",
			["/company/00000006/registered-office-address"] = "{}",
			["/company/00000006/officers"] = "{\"items\":[{\"links\":{\"self\":\"/company/00000006/appointments/appt1\",\"officer\":{\"appointments\":\"/officers/officer1/appointments\"}}}],\"total_results\":1}",
			["/company/00000006/appointments/appt1"] = "{}",
			["/company/00000006/registers"] = "{}",
			["/company/00000006/filing-history"] = "{\"items\":[{\"transaction_id\":\"tx1\"}]}",
			["/company/00000006/filing-history/tx1"] = "{}",
			["/disqualified-officers/natural/officer1"] = "{}",
			["/disqualified-officers/corporate/officer2"] = "{}",
			["/company/00000006/uk-establishments"] = "{\"items\":[{}]}",
			["/company/00000006/charges"] = "{\"items\":[{\"charge_code\":\"charge1\"}],\"total_count\":1}",
			["/company/00000006/charges/charge1"] = "{}",
			["/company/00000006/insolvency"] = "{\"cases\":[{}]}",
			["/company/00000006/exemptions"] = "{}",
			["/company/00000006/persons-with-significant-control/corporate-entity/psc1"] = "{}",
			["/company/00000006/persons-with-significant-control/individual/psc2"] = "{}",
			["/company/00000006/persons-with-significant-control/legal-person/psc3"] = "{}",
			["/company/00000006/persons-with-significant-control-statements/statement1"] = "{}",
			["/company/00000006/persons-with-significant-control/super-secure/secure1"] = "{}",
			["/company/00000006/persons-with-significant-control"] = "{}",
			["/company/00000006/persons-with-significant-control-statements"] = "{}",
			["/officers/officer1/appointments"] = "{\"items\":[{}],\"total_results\":1,\"name\":\"Example Officer\"}"
		});

		using var httpClient = new HttpClient(handler)
		{
			BaseAddress = new Uri("https://example.test/")
		};

		var client = new CompaniesHouseClient(httpClient);
		var cancellationToken = CancellationToken.None;

		(await client.Search.GetInfoByNameAsync("test", cancellationToken)).Should().NotBeNull();
		(await client.Search.GetCompanyInfoByNameAsync("test", cancellationToken)).TotalResults.Should().Be(1);
		(await client.Search.GetOfficerInfoByNameAsync("test", cancellationToken)).TotalResults.Should().Be(1);
		(await client.Search.GetDisqualifiedOfficerInfoByNameAsync("test", cancellationToken)).TotalResults.Should().Be(1);

		(await client.Company.GetByIdAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetRegisteredAddressAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetOfficerListByIdAsync("00000006", cancellationToken)).Items.Should().HaveCount(1);
		(await client.Company.GetOfficerInformationByAppointmentAsync("00000006", "appt1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetRegisterInfoByIdAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetFilingHistoryListByIdAsync("00000006", cancellationToken)).Items.Should().HaveCount(1);
		(await client.Company.GetFilingHistoryByIdAsync("00000006", "tx1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetNaturalDisqualifiedByIdAsync("officer1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetCorporateDisqualifiedByIdAsync("officer2", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetUkEstablishmentsByIdAsync("00000006", cancellationToken)).Items.Should().HaveCount(1);
		(await client.Company.GetChargesListByIdAsync("00000006", cancellationToken)).Items.Should().HaveCount(1);
		(await client.Company.GetChargesByIdAsync("00000006", "charge1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetInsolvencyByIdAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetExemptionsByIdAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetCorporateEntityByIdAsync("00000006", "psc1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetIndividualByIdAsync("00000006", "psc2", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetLegalPersonByIdAsync("00000006", "psc3", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetStatementByIdAsync("00000006", "statement1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetSuperSecureByIdAsync("00000006", "secure1", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetPWSCListByIdAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetStatementListByIdAsync("00000006", cancellationToken)).Should().NotBeNull();
		(await client.Company.GetOfficerAppointmentsAsync("officer1", cancellationToken)).Items.Should().HaveCount(1);

		handler.RequestedPaths.Should().Contain("/search/disqualified-officers?q=test");
		handler.RequestedPaths.Should().Contain("/company/00000006/charges/charge1");
		handler.RequestedPaths.Should().Contain("/officers/officer1/appointments");
        handler.RequestedPaths.Should().HaveCount(expectedMethodCount);
		handler.RequestedPaths.Distinct().Should().HaveCount(expectedMethodCount);
	}

	private sealed class StubHttpMessageHandler(Dictionary<string, string> responses) : HttpMessageHandler
	{
		private readonly Dictionary<string, string> _responses = responses;

		public List<string> RequestedPaths { get; } = [];

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var pathAndQuery = request.RequestUri?.PathAndQuery ?? string.Empty;
			RequestedPaths.Add(pathAndQuery);

			if (!_responses.TryGetValue(pathAndQuery, out var body))
			{
				throw new InvalidOperationException($"No stubbed response configured for '{pathAndQuery}'.");
			}

			return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = new StringContent(body, Encoding.UTF8, "application/json")
			});
		}
	}
}
