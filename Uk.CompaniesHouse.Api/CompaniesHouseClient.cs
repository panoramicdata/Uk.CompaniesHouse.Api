using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Net.Http;
using Uk.CompaniesHouse.Api.Interfaces;

namespace Uk.CompaniesHouse.Api;

public class CompaniesHouseClient
{
	private const string LiveBaseUrl = "https://api.company-information.service.gov.uk/";
	private const string SandboxBaseUrl = "https://api-sandbox.company-information.service.gov.uk/";

	public CompaniesHouseClient(CompaniesHouseClientOptions options, ILogger logger)
      : this(CreateHttpClient(options, logger))
	{
	}

  internal static string GetBaseUrl(ApiEnvironment environment) => environment switch
	{
		ApiEnvironment.Live => LiveBaseUrl,
		ApiEnvironment.Sandbox => SandboxBaseUrl,
		_ => throw new ArgumentOutOfRangeException(nameof(environment), environment, "Unknown API environment.")
	};

	private static HttpClient CreateHttpClient(CompaniesHouseClientOptions options, ILogger logger)
	{
		AuthenticatedHttpClientHandler.ValidateOptions(options);

		return new HttpClient(new AuthenticatedHttpClientHandler(options, logger))
		{
			BaseAddress = new Uri(GetBaseUrl(options.Environment))
		};
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