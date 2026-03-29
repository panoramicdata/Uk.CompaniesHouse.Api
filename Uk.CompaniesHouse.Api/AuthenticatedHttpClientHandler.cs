using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uk.CompaniesHouse.Api;

internal class AuthenticatedHttpClientHandler(
	CompaniesHouseClientOptions options,
	ILogger logger) : HttpClientHandler
{
	internal const string UserAgentHeader = "User-Agent";
	private const string AuthorizationHeader = "Authorization";
	private readonly CompaniesHouseClientOptions _options = options;
	private readonly ILogger _logger = logger;

	internal static void ValidateOptions(CompaniesHouseClientOptions options)
	{
		_ = GetAuthorizationHeaderValue(options);
	}

	internal static string GetAuthorizationHeaderValue(CompaniesHouseClientOptions options) => options.AuthenticationMode switch
	{
		CompaniesHouseAuthenticationMode.ApiKey => $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"{GetRequiredApiKey(options)}:"))}",
		CompaniesHouseAuthenticationMode.OAuthBearerToken => $"Bearer {GetRequiredAccessToken(options)}",
		_ => throw new ArgumentOutOfRangeException(nameof(options.AuthenticationMode), options.AuthenticationMode, "Unknown authentication mode.")
	};

	private static string GetRequiredApiKey(CompaniesHouseClientOptions options) =>
		!string.IsNullOrWhiteSpace(options.ApiKey)
			? options.ApiKey
			: throw new InvalidOperationException("ApiKey must be provided when using ApiKey authentication.");

	private static string GetRequiredAccessToken(CompaniesHouseClientOptions options) =>
		!string.IsNullOrWhiteSpace(options.AccessToken)
			? options.AccessToken
			: throw new InvalidOperationException("AccessToken must be provided when using OAuthBearerToken authentication.");

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		if (!request.Headers.TryGetValues(UserAgentHeader, out _) && !string.IsNullOrWhiteSpace(_options.UserAgent))
		{
			request.Headers.Add(UserAgentHeader, _options.UserAgent);
		}

		if (!request.Headers.TryGetValues(AuthorizationHeader, out _))
		{
			request.Headers.Authorization = AuthenticationHeaderValue.Parse(GetAuthorizationHeaderValue(_options));
		}

		// Get a GUID to uniquely identify the request
		var guid = Guid.NewGuid();
		_logger.LogDebug($"{guid}:{request.Method}:{request.RequestUri}\nHeaders:{request.Headers}\nBody:{(request.Content is null ? null : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false))}");

		var response = await base
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		_logger.LogDebug($"{guid}:{response.StatusCode}:{await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)}");

		return response;
	}
}