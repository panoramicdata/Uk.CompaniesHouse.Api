using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Net.Http;
using Uk.CompaniesHouse.Api.Interfaces;

namespace Uk.CompaniesHouse.Api;

public class CompaniesHouseClient
{
	public CompaniesHouseClient(CompaniesHouseClientOptions options, ILogger logger)
		: this(new HttpClient(new AuthenticatedHttpClientHandler(options, logger))
		{
			BaseAddress = new Uri("https://api.company-information.service.gov.uk/")
		})
	{
	}

	public CompaniesHouseClient(HttpClient httpClient)
	{
		var settings = new RefitSettings(new NewtonsoftJsonContentSerializer());

		Search = RestService.For<ISearch>(httpClient, settings);
		Company = RestService.For<ICompany>(httpClient, settings);
	}

	/// <summary>
	/// Search API
	/// </summary>
	public ISearch Search { get; }

	/// <summary>
	/// Company API
	/// </summary>
	public ICompany Company { get; }
}