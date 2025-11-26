using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Uk.CompaniesHouse.Api;

internal class AuthenticatedHttpClientHandler(
	CompaniesHouseClientOptions options,
	ILogger logger) : HttpClientHandler
{
	private const string UserAgentHeader = "UserAgent";
	private const string AuthorizationHeader = "Authorization";
	private readonly CompaniesHouseClientOptions _options = options;
	private readonly ILogger _logger = logger;

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		if (!request.Headers.TryGetValues(UserAgentHeader, out _))
		{
			request.Headers.Add(UserAgentHeader, _options.UserAgent);
		}
		if (!request.Headers.TryGetValues(AuthorizationHeader, out _))
		{
			var plainTextBytes = Encoding.UTF8.GetBytes(_options.ApiKey + ":");
			var authorization = Convert.ToBase64String(plainTextBytes);
			request.Headers.Add(AuthorizationHeader, $"Basic {authorization}");
		}

		// Get a GUID to uniquely identify the request
		var guid = Guid.NewGuid();
		_logger.LogDebug($"{guid}:{request.Method}:{request.RequestUri}\nHeaders:{request.Headers}\nBody:{(request.Content is null ? null : await request.Content.ReadAsStringAsync().ConfigureAwait(false))}");

		var response = await base
			.SendAsync(request, cancellationToken)
			.ConfigureAwait(false);

		_logger.LogDebug($"{guid}:{response.StatusCode}:{await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");

		return response;
	}
}