# Copilot Instructions for Uk.CompaniesHouse.Api

## General Guidelines

- This project targets .NET 10.0
- Follow existing code style and conventions
- All warnings are treated as errors (`TreatWarningsAsErrors` is enabled)
- Nullable reference types are enabled

## NuGet Package README

**IMPORTANT**: When creating or editing README.md files that will be included in NuGet packages:

- **DO NOT use Unicode characters or emojis** - The NuGet UI does not properly support them and they may appear as question marks (???)
- Use plain ASCII characters only
- Use standard markdown formatting instead of special characters for visual enhancement
- For bullet points, use simple `-` or `*` characters
- For emphasis, use `**bold**` or `*italic*` markdown

### Examples

? **Avoid:**
```markdown
- ?? **Company Search** - Search for companies
- ?? **Officers** - Access officer lists
- ?? **Filing History** - View filing history
```

? **Use instead:**
```markdown
- **Company Search** - Search for companies
- **Officers** - Access officer lists
- **Filing History** - View filing history
```

## Testing

- All unit tests must pass before publishing
- Use the `Publish.ps1` script for publishing to NuGet
- API key should be stored in `nuget-key.txt` (gitignored)
- Test project uses xUnit framework

## Dependencies

- Microsoft.Extensions.Logging.Abstractions (10.0.0)
- Refit (8.0.0)
- Refit.Newtonsoft.Json (8.0.0)
- Nerdbank.GitVersioning (3.9.50)

## Versioning

- Uses Nerdbank.GitVersioning for semantic versioning
- Version information is stored in `version.json`
- Version increments automatically based on git history
