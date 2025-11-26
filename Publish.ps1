#!/usr/bin/env pwsh

<#
.SYNOPSIS
    Publishes the Uk.CompaniesHouse.Api NuGet package.

.DESCRIPTION
    This script performs the following steps:
    1. Checks git status (porcelain) to ensure working directory is clean
    2. Runs unit tests
    3. Publishes the package to NuGet using API key from nuget-key.txt

.PARAMETER SkipTests
    Skip running unit tests (not recommended for production)

.PARAMETER Force
    Force publish even if working directory is not clean (not recommended)

.EXAMPLE
    .\Publish.ps1
    
.EXAMPLE
    .\Publish.ps1 -SkipTests
#>

[CmdletBinding()]
param(
    [Parameter(Mandatory = $false)]
    [switch]$SkipTests,
    
    [Parameter(Mandatory = $false)]
    [switch]$Force
)

$ErrorActionPreference = "Stop"

# Colors for output
function Write-Info($message) {
    Write-Information $message -InformationAction Continue
}

function Write-Success($message) {
    Write-Information $message -InformationAction Continue
}

function Write-Warning($message) {
    Microsoft.PowerShell.Utility\Write-Warning $message
}

function Write-Error($message) {
    Microsoft.PowerShell.Utility\Write-Error $message
}

# Banner
Write-Info "=================================================="
Write-Info "  Uk.CompaniesHouse.Api NuGet Package Publisher"
Write-Info "=================================================="
Write-Information "" -InformationAction Continue

# Step 1: Check git status (porcelain)
Write-Info "Step 1: Checking git status..."
$gitStatus = git status --porcelain
if ($gitStatus -and -not $Force) {
    Write-Error "Working directory is not clean. Uncommitted changes detected:"
    Write-Information $gitStatus -InformationAction Continue
    Write-Host ""
    Write-Warning "Please commit or stash your changes before publishing."
    Write-Warning "Or use -Force parameter to publish anyway (not recommended)."
    exit 1
}
elseif ($gitStatus -and $Force) {
    Write-Warning "Working directory is not clean, but Force parameter specified. Continuing..."
}
else {
    Write-Success "Working directory is clean."
}
Write-Host ""

# Step 2: Run unit tests
if (-not $SkipTests) {
    Write-Info "Step 2: Running unit tests..."
    $testProject = "Uk.CompaniesHouse.Api.Test\Uk.CompaniesHouse.Api.Test.csproj"
    
    if (-not (Test-Path $testProject)) {
        Write-Error "Test project not found at: $testProject"
        exit 1
    }
    
    dotnet test $testProject --configuration Release --verbosity minimal
    
    if ($LASTEXITCODE -ne 0) {
        Write-Error "Unit tests failed. Aborting publish."
        exit 1
    }
    
    Write-Success "All unit tests passed."
}
else {
    Write-Warning "Step 2: Skipping unit tests (SkipTests parameter specified)."
}
Write-Host ""

# Step 3: Check for NuGet API key
Write-Info "Step 3: Reading NuGet API key..."
$nugetKeyFile = "nuget-key.txt"

if (-not (Test-Path $nugetKeyFile)) {
    Write-Error "NuGet API key file not found: $nugetKeyFile"
    Write-Host ""
    Write-Info "Please create a file named 'nuget-key.txt' in the root directory containing your NuGet API key."
    Write-Info "This file is gitignored for security."
    exit 1
}

$nugetApiKey = Get-Content $nugetKeyFile -Raw
$nugetApiKey = $nugetApiKey.Trim()

if ([string]::IsNullOrWhiteSpace($nugetApiKey)) {
    Write-Error "NuGet API key file is empty: $nugetKeyFile"
    exit 1
}

Write-Success "NuGet API key loaded successfully."
Write-Host ""

# Step 4: Build and pack the project
Write-Info "Step 4: Building and packing the project..."
$mainProject = "Uk.CompaniesHouse.Api\Uk.CompaniesHouse.Api.csproj"

if (-not (Test-Path $mainProject)) {
    Write-Error "Main project not found at: $mainProject"
    exit 1
}

# Clean previous build artifacts
Write-Info "Cleaning previous build artifacts..."
dotnet clean $mainProject --configuration Release --verbosity minimal

# Build in Release mode (GeneratePackageOnBuild is true in csproj)
Write-Info "Building Release configuration..."
dotnet build $mainProject --configuration Release --verbosity minimal

if ($LASTEXITCODE -ne 0) {
    Write-Error "Build failed. Aborting publish."
    exit 1
}

Write-Success "Build completed successfully."
Write-Host ""

# Step 5: Find the generated NuGet package
Write-Info "Step 5: Locating NuGet package..."
$packagePath = Get-ChildItem -Path "Uk.CompaniesHouse.Api\bin\Release" -Filter "*.nupkg" -Recurse | 
    Where-Object { $_.Name -notlike "*.symbols.nupkg" } |
    Sort-Object LastWriteTime -Descending |
    Select-Object -First 1

if (-not $packagePath) {
    Write-Error "No NuGet package found in Uk.CompaniesHouse.Api\bin\Release"
    exit 1
}

Write-Success "Found package: $($packagePath.FullName)"
Write-Host ""

# Step 6: Publish to NuGet
Write-Info "Step 6: Publishing to NuGet.org..."
Write-Warning "Publishing package: $($packagePath.Name)"
Write-Host ""

dotnet nuget push $packagePath.FullName --api-key $nugetApiKey --source https://api.nuget.org/v3/index.json --skip-duplicate

if ($LASTEXITCODE -ne 0) {
    Write-Error "NuGet publish failed."
    exit 1
}

Write-Host ""
Write-Success "=================================================="
Write-Success "  Package published successfully!"
Write-Success "=================================================="
Write-Host ""
Write-Info "Package: $($packagePath.Name)"
Write-Info "It may take a few minutes for the package to appear on NuGet.org"
Write-Host ""
