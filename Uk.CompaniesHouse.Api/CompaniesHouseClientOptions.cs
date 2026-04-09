namespace Uk.CompaniesHouse.Api;

/// <summary>
/// Defines configuration values for authenticating and connecting to Companies House.
/// </summary>
public record CompaniesHouseClientOptions
{
	/// <summary>
	/// Gets or sets the API key used for API key authentication.
	/// </summary>
	public string ApiKey { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the access token used for OAuth authentication.
	/// </summary>
	public string AccessToken { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the authentication mode used when sending requests.
	/// </summary>
	public CompaniesHouseAuthenticationMode AuthenticationMode { get; set; } = CompaniesHouseAuthenticationMode.ApiKey;

	/// <summary>
	/// Gets or sets the user agent header value sent with requests.
	/// </summary>
	public string? UserAgent { get; set; } = "Uk.CompaniesHouse.Api";

	/// <summary>
	/// Gets or sets the Companies House API environment to target.
	/// </summary>
	public ApiEnvironment Environment { get; set; } = ApiEnvironment.Live;
}