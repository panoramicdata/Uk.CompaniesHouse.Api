# Uk.CompaniesHouse.Api

[![Nuget](https://img.shields.io/nuget/v/Uk.CompaniesHouse.Api)](https://www.nuget.org/packages/Uk.CompaniesHouse.Api/)
[![Nuget](https://img.shields.io/nuget/dt/Uk.CompaniesHouse.Api)](https://www.nuget.org/packages/Uk.CompaniesHouse.Api/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/737357523e2245a498448048bcd06f90)](https://app.codacy.com/gh/panoramicdata/Uk.CompaniesHouse.Api/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

A .NET library for interacting with the UK Companies House APIs.

## Features

- Company profile retrieval
- Registered office address lookup
- Officer list and appointment lookup
- Officer appointments by officer ID
- Filing history list and item lookup
- Company registers
- Charges
- Insolvency
- Exemptions
- UK establishments
- Persons with significant control (PSC)
- PSC statements
- Natural and corporate disqualified officer lookup
- Search across companies, officers, and disqualified officers
- Live and sandbox environment selection
- API key and OAuth bearer token authentication modes

## Installation

### Package Manager Console
```powershell
Install-Package Uk.CompaniesHouse.Api
```

### .NET CLI
```bash
dotnet add package Uk.CompaniesHouse.Api
```

### PackageReference
```xml
<PackageReference Include="Uk.CompaniesHouse.Api" Version="10.0.*" />
```

## Authentication

The client supports both authentication modes documented by Companies House:

- API key over HTTP Basic authentication
- OAuth 2.0 bearer access token authentication

### API key authentication

```csharp
using Microsoft.Extensions.Logging;
using Uk.CompaniesHouse.Api;

var logger = LoggerFactory.Create(builder => builder.AddConsole())
    .CreateLogger<CompaniesHouseClient>();

var options = new CompaniesHouseClientOptions
{
    ApiKey = "your-api-key",
    AuthenticationMode = CompaniesHouseAuthenticationMode.ApiKey,
    Environment = ApiEnvironment.Live,
    UserAgent = "MyApplication/1.0"
};

var client = new CompaniesHouseClient(options, logger);
```

### OAuth bearer token authentication

```csharp
using Microsoft.Extensions.Logging;
using Uk.CompaniesHouse.Api;

var logger = LoggerFactory.Create(builder => builder.AddConsole())
    .CreateLogger<CompaniesHouseClient>();

var options = new CompaniesHouseClientOptions
{
    AccessToken = "your-access-token",
    AuthenticationMode = CompaniesHouseAuthenticationMode.OAuthBearerToken,
    Environment = ApiEnvironment.Live,
    UserAgent = "MyApplication/1.0"
};

var client = new CompaniesHouseClient(options, logger);
```

## Environments

The client supports both public data environments:

- `ApiEnvironment.Live` -> `https://api.company-information.service.gov.uk/`
- `ApiEnvironment.Sandbox` -> `https://api-sandbox.company-information.service.gov.uk/`

## URLs used

The following URLs are relevant when using or testing this library:

- Public Data API (live): `https://api.company-information.service.gov.uk/`
- Public Data API (sandbox): `https://api-sandbox.company-information.service.gov.uk/`
- Identity service (sandbox OAuth testing): `https://identity-sandbox.company-information.service.gov.uk/`
- Sandbox test data generator: `https://test-data-sandbox.company-information.service.gov.uk/`
- Developer specifications: `https://developer-specs.company-information.service.gov.uk/`

This package directly calls the Public Data API live or sandbox base URL depending on `ApiEnvironment`.
The identity service and sandbox test data generator are companion services that may be used when testing OAuth flows or creating sandbox data.

```csharp
var options = new CompaniesHouseClientOptions
{
    ApiKey = "your-api-key",
    Environment = ApiEnvironment.Sandbox
};
```

## Usage

### Search for companies

```csharp
var searchResults = await client.Search
    .GetCompanyInfoByNameAsync("Panoramic Data Limited", cancellationToken);

foreach (var company in searchResults.Items)
{
    Console.WriteLine($"{company.Title} - {company.CompanyNumber}");
}
```

### Get a company profile

```csharp
var company = await client.Company
    .GetByIdAsync("06982102", cancellationToken);

Console.WriteLine(company.CompanyName);
```

### Get company officers

```csharp
var officers = await client.Company
    .GetOfficerListByIdAsync("06982102", cancellationToken);

foreach (var officer in officers.Items)
{
    Console.WriteLine($"{officer.Name} - {officer.OfficerRole}");
}
```

### Get officer appointments by officer ID

```csharp
var appointments = await client.Company
    .GetOfficerAppointmentsAsync("officer-id", cancellationToken);

foreach (var appointment in appointments.Items)
{
    Console.WriteLine($"{appointment.AppointedToCompanyName} - {appointment.OfficerRole}");
}
```

### Get a specific filing history item

```csharp
var filing = await client.Company
    .GetFilingHistoryByIdAsync("06982102", "transaction-id", cancellationToken);

Console.WriteLine($"{filing.Date} - {filing.Description}");
```

### Get charges

```csharp
var charges = await client.Company
    .GetChargesListByIdAsync("06982102", cancellationToken);

foreach (var charge in charges.Items)
{
    Console.WriteLine(charge.ChargeCode);
}
```

## Supported client surface

### Search API

- `GetInfoByNameAsync`
- `GetCompanyInfoByNameAsync`
- `GetOfficerInfoByNameAsync`
- `GetDisqualifiedOfficerInfoByNameAsync`

### Company API

- `GetByIdAsync`
- `GetRegisteredAddressAsync`
- `GetOfficerListByIdAsync`
- `GetOfficerInformationByAppointmentAsync`
- `GetRegisterInfoByIdAsync`
- `GetFilingHistoryListByIdAsync`
- `GetFilingHistoryByIdAsync`
- `GetNaturalDisqualifiedByIdAsync`
- `GetCorporateDisqualifiedByIdAsync`
- `GetUkEstablishmentsByIdAsync`
- `GetChargesListByIdAsync`
- `GetChargesByIdAsync`
- `GetInsolvencyByIdAsync`
- `GetExemptionsByIdAsync`
- `GetCorporateEntityByIdAsync`
- `GetIndividualByIdAsync`
- `GetLegalPersonByIdAsync`
- `GetStatementByIdAsync`
- `GetSuperSecureByIdAsync`
- `GetPWSCListByIdAsync`
- `GetStatementListByIdAsync`
- `GetOfficerAppointmentsAsync`

## Testing

The test project supports `User Secrets` for local credentials.

Example:

```json
{
  "AppSettings": {
    "ApiKey": "your-companies-house-api-key-here",
    "AuthenticationMode": "ApiKey",
    "Environment": "Sandbox"
  }
}
```

Set secrets with:

```powershell
dotnet user-secrets set "AppSettings:ApiKey" "your-key" --project Uk.CompaniesHouse.Api.Test
dotnet user-secrets set "AppSettings:AuthenticationMode" "ApiKey" --project Uk.CompaniesHouse.Api.Test
dotnet user-secrets set "AppSettings:Environment" "Sandbox" --project Uk.CompaniesHouse.Api.Test
```

For bearer token testing:

```powershell
dotnet user-secrets set "AppSettings:AuthenticationMode" "OAuthBearerToken" --project Uk.CompaniesHouse.Api.Test
dotnet user-secrets set "AppSettings:AccessToken" "your-access-token" --project Uk.CompaniesHouse.Api.Test
```

Coverage (full, Test Explorer-style output):

```powershell
dotnet test Uk.CompaniesHouse.Api.slnx --collect:"XPlat Code Coverage" --settings coverage.runsettings -v minimal
```

Coverage (production-only, excludes test assembly and generated/runtime noise):

```powershell
dotnet test Uk.CompaniesHouse.Api.slnx --collect:"XPlat Code Coverage" --settings coverage.production.runsettings -v minimal
```

## Notes

- Sandbox data differs from live Companies House data.
- The deterministic test suite validates the full client surface without depending on live network data.
- OAuth token acquisition is outside the scope of this package. Supply an access token obtained by your own OAuth flow.

## API Reference

Official documentation:
https://developer-specs.company-information.service.gov.uk/

## License

This project is licensed under the MIT License. See `LICENSE`.

## Support

For issues and contributions, visit:
https://github.com/panoramicdata/Uk.CompaniesHouse.Api
