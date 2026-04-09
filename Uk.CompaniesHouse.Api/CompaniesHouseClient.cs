using Microsoft.Extensions.Logging;
using Refit;
using System;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using Uk.CompaniesHouse.Api.Interfaces;

namespace Uk.CompaniesHouse.Api;

/// <summary>
/// Provides typed access to the UK Companies House search and company endpoints.
/// </summary>
public class CompaniesHouseClient
{
	private const string LiveBaseUrl = "https://api.company-information.service.gov.uk/";
	private const string SandboxBaseUrl = "https://api-sandbox.company-information.service.gov.uk/";

	/// <summary>
	/// Creates a client using the supplied Companies House options and logger.
	/// </summary>
	/// <param name="options">The options used to configure authentication and environment.</param>
	/// <param name="logger">The logger used by the authenticated HTTP handler.</param>
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

	/// <summary>
	/// Creates a client using an already configured HTTP client.
	/// </summary>
	/// <param name="httpClient">The HTTP client to use for all API requests.</param>
	public CompaniesHouseClient(HttpClient httpClient)
	{
		var settings = new RefitSettings(new SystemTextJsonContentSerializer(CreateJsonSerializerOptions()));

		Search = RestService.For<ISearch>(httpClient, settings);
		Company = RestService.For<ICompany>(httpClient, settings);
	}

	private static JsonSerializerOptions CreateJsonSerializerOptions()
	{
		var resolver = new DefaultJsonTypeInfoResolver();
		resolver.Modifiers.Add(static typeInfo =>
		{
			if (typeInfo.Kind != JsonTypeInfoKind.Object)
			{
				return;
			}

			foreach (var property in typeInfo.Properties)
			{
				var dataMemberAttribute = (property.AttributeProvider as ICustomAttributeProvider)?
					.GetCustomAttributes(typeof(DataMemberAttribute), inherit: true)
					.OfType<DataMemberAttribute>()
					.FirstOrDefault();

				if (!string.IsNullOrWhiteSpace(dataMemberAttribute?.Name))
				{
					property.Name = dataMemberAttribute.Name;
				}
			}
		});

		return new JsonSerializerOptions(JsonSerializerDefaults.Web)
		{
			PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
			DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower,
			TypeInfoResolver = resolver
		};
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