namespace Uk.CompaniesHouse.Api;

/// <summary>
/// The Companies House API environment to connect to.
/// </summary>
public enum ApiEnvironment
{
	/// <summary>
	/// The live production API at https://api.company-information.service.gov.uk/
	/// </summary>
	Live,

	/// <summary>
	/// The sandbox testing API at https://api-sandbox.company-information.service.gov.uk/
	/// </summary>
	Sandbox
}
