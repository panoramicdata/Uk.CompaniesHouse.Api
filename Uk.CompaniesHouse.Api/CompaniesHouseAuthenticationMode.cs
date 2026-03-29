namespace Uk.CompaniesHouse.Api;

/// <summary>
/// The authentication mode used when calling Companies House APIs.
/// </summary>
public enum CompaniesHouseAuthenticationMode
{
	/// <summary>
	/// HTTP Basic authentication using an API key as the username.
	/// </summary>
	ApiKey,

	/// <summary>
	/// HTTP Bearer authentication using an OAuth 2.0 access token.
	/// </summary>
	OAuthBearerToken
}
