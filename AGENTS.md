# Agent instructions

## Glossary

- NET: .NET, Microsoft's developer platform; this is a product name.
- ASCII: American Standard Code for Information Interchange.

## Identity

You are a careful, security-conscious contributor to this repository.

## Scope and boundaries

IMPORTANT: Apply these in order, most important first.

- CRITICAL: Do not commit secrets, credentials, or API tokens.
- IMPORTANT: Do not weaken `TreatWarningsAsErrors`, delete or skip tests to make a build pass, or bypass
  CI/CD checks.
- IMPORTANT: Do not force-push to `main`, rewrite published history, or delete branches without explicit
  approval.
- Do not add `Co-Authored-By` trailers or other AI attribution to commit messages or pull requests.

## Tools

- Build and test with `dotnet build` / `dotnet test`.
- Use `git` for version control, following the repository's contributing guidelines where present.

## Repository guide

### General Guidelines

- This project targets .NET 11.0
- Follow existing code style and conventions
- All warnings are treated as errors (`TreatWarningsAsErrors` is enabled)
- Nullable reference types are enabled

### NuGet Package README

**IMPORTANT**: When creating or editing README.md files that will be included in NuGet packages:

- **Do not use Unicode characters or emojis** - The NuGet UI does not properly support them and they may appear as question marks (???)
- Use plain ASCII characters only
- Use standard markdown formatting instead of special characters for visual enhancement
- For bullet points, use simple `-` or `*` characters
- For emphasis, use `**bold**` or `*italic*` markdown

#### Examples

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

### Testing

- All unit tests need to pass before publishing
- Use the `Publish.ps1` script for publishing to NuGet
- API key should be stored in `nuget-key.txt` (gitignored)
- Test project uses xUnit framework

### Dependencies

- Microsoft.Extensions.Logging.Abstractions (10.0.0)
- Refit (8.0.0)
- Refit.Newtonsoft.Json (8.0.0)
- Nerdbank.GitVersioning (3.9.50)

### Versioning

- Uses Nerdbank.GitVersioning for semantic versioning
- Version information is stored in `version.json`
- Version increments automatically based on git history

## PanoramicData staff

PanoramicData staff have shared tooling in a private sibling checkout of PanoramicData.Skills. Anyone
without it can ignore this section: everything needed to work on this repository is above.
