namespace Uk.CompaniesHouse.Api;

public record CompaniesHouseClientOptions
{
	public string ApiKey { get; set; } = string.Empty;

	public string AccessToken { get; set; } = string.Empty;

	public CompaniesHouseAuthenticationMode AuthenticationMode { get; set; } = CompaniesHouseAuthenticationMode.ApiKey;

	public string? UserAgent { get; set; } = "Uk.CompaniesHouse.Api";

	public ApiEnvironment Environment { get; set; } = ApiEnvironment.Live;
}