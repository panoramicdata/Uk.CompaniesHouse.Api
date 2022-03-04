# Uk.CompaniesHouse.Api

A nuget package for the Companies House REST API.

[![Nuget](https://img.shields.io/nuget/v/Uk.CompaniesHouse.Api)](https://www.nuget.org/packages/Uk.CompaniesHouse.Api/)

To use the Companies House nuget package:

## Visual Studio

1. Open your project in Visual Studio
1. Right-click on the project and click "Manage Nuget packages"
1. Find the package "Uk.CompaniesHouse.Api" - install the latest version

## Example code (C# 8.0):

``` C#
using Uk.CompaniesHouse.Api;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace My.Project
{
	public static class Program
	{
		public static async Task Main()
		{
			var filingHistoryInfo = await Client
				.Company
				.GetFilingHistoryByIdAsync("<EXAMPLE ID>, default")
				.ConfigureAwait(false);

			Console.WriteLine($"Action date: {filingHistoryInfo.Items[0].ActionDate}");
		}
	}
}
````
