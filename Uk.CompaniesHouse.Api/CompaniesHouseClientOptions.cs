namespace Uk.CompaniesHouse.Api;

public record CompaniesHouseClientOptions
{
	public string ApiKey { get; set; } = string.Empty;
	public string? UserAgent { get; set; } = "Uk.CompaniesHouse.Api";
	public string BaseUrl { get; set; } = "https://api.company-information.service.gov.uk/";
}