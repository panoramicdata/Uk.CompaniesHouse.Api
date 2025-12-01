# Uk.CompaniesHouse.Api

[![Nuget](https://img.shields.io/nuget/v/Uk.CompaniesHouse.Api)](https://www.nuget.org/packages/Uk.CompaniesHouse.Api/)
[![Nuget](https://img.shields.io/nuget/dt/Uk.CompaniesHouse.Api)](https://www.nuget.org/packages/Uk.CompaniesHouse.Api/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/737357523e2245a498448048bcd06f90)](https://app.codacy.com/gh/panoramicdata/Uk.CompaniesHouse.Api/dashboard?utm_source=gh&utm_medium=referral&utm_content=&utm_campaign=Badge_grade)

A .NET library for interacting with the [UK Companies House API](https://developer.company-information.service.gov.uk/api/docs/).

## Features

- **Company Search** - Search for companies by name
- **Company Information** - Retrieve detailed company profiles
- **Officers** - Access officer lists and appointment details
- **Filing History** - View company filing history
- **Persons with Significant Control (PSC)** - Access PSC information
- **Charges** - Retrieve company charges and secured details
- **Disqualified Officers** - Access disqualified officer information
- **UK Establishments** - View UK establishment details
- **Insolvency** - Access insolvency information
- **Registers** - View company register information
- **Exemptions** - Access company exemptions

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

## Prerequisites

You will need an API key from Companies House to use this library. You can register for a free API key at:
https://developer.company-information.service.gov.uk/

## Usage

### Basic Setup

```csharp
using Microsoft.Extensions.Logging;
using Uk.CompaniesHouse.Api;

// Create logger (using your preferred logging framework)
var logger = LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger<CompaniesHouseClient>();

// Configure the client with your API key
var options = new CompaniesHouseClientOptions
{
    ApiKey = "your-api-key-here",
    UserAgent = "MyApplication/1.0"
};

// Create the client
var client = new CompaniesHouseClient(options, logger);
```

### Search for Companies

```csharp
// Search for a company by name
var searchResults = await client.Search
    .GetCompanyInfoByNameAsync("Panoramic Data Limited", cancellationToken);

Console.WriteLine($"Found {searchResults.TotalResults} companies");

foreach (var company in searchResults.Items)
{
    Console.WriteLine($"{company.Title} - {company.CompanyNumber}");
}
```

### Get Company Details

```csharp
// Get detailed company information
var company = await client.Company
    .GetByIdAsync("06982102", cancellationToken);

Console.WriteLine($"Company Name: {company.CompanyName}");
Console.WriteLine($"Company Status: {company.CompanyStatus}");
Console.WriteLine($"Incorporation Date: {company.CreationDate}");
```

### Get Company Officers

```csharp
// Get list of company officers
var officers = await client.Company
    .GetOfficerListByIdAsync("06982102", cancellationToken);

foreach (var officer in officers.Items)
{
    Console.WriteLine($"{officer.Name} - {officer.OfficerRole}");
}
```

### Get Filing History

```csharp
// Get company filing history
var filingHistory = await client.Company
    .GetFilingHistoryListByIdAsync("06982102", cancellationToken);

foreach (var filing in filingHistory.Items)
{
    Console.WriteLine($"{filing.Date}: {filing.Description}");
}
```

### Get Persons with Significant Control

```csharp
// Get PSC list
var pscList = await client.Company
    .GetPWSCListByIdAsync("06982102", cancellationToken);

foreach (var psc in pscList.Items)
{
    Console.WriteLine($"PSC: {psc.Name}");
}
```

### Get Company Charges

```csharp
// Get list of charges
var charges = await client.Company
    .GetChargesListByIdAsync("06982102", cancellationToken);

foreach (var charge in charges.Items)
{
    Console.WriteLine($"Charge ID: {charge.ChargeNumber}");
}
```

## API Reference

For complete API documentation, please refer to the official Companies House API documentation:
https://developer.company-information.service.gov.uk/api/docs/

## Supported Endpoints

This library supports the following Companies House API endpoints:

### Company API
- Get company profile
- Get registered office address
- Get officers
- Get officer appointments
- Get registers
- Get filing history
- Get UK establishments
- Get charges
- Get insolvency information
- Get exemptions
- Get persons with significant control
- Get PSC statements

### Search API
- Search companies
- Search officers
- Search disqualified officers

### Disqualified Officers API
- Get natural disqualified officer details
- Get corporate disqualified officer details

## Requirements

- .NET 10.0 or later
- Valid Companies House API key

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

For issues, questions, or contributions, please visit the [GitHub repository](https://github.com/panoramicdata/Uk.CompaniesHouse.Api).

## Related Projects

- [Meraki.Api](https://github.com/panoramicdata/Meraki.Api) - .NET library for Cisco Meraki Dashboard API

## Acknowledgments

Built by [Panoramic Data Limited](https://www.panoramicdata.com/)

---

**Note**: This is an unofficial library and is not affiliated with or endorsed by Companies House.
