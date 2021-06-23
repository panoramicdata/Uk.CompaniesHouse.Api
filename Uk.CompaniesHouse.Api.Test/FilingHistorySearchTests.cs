using FluentAssertions;
using Microsoft.Extensions.Options;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class FilingHistorySearchTests : TestBase
	{
		public FilingHistorySearchTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetFilingHistoryByIdAsync("06982102", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();

			var item = result.Items[0];

			item.ActionDate.Should().Be("2020-09-30");
			item.Category.Should().Be("accounts");

			var descValues = item.DescriptionValues;
			descValues.MadeUpDate.Should().Be("2020-09-30");

			item.Pages.Should().Be(3);
			item.Barcode.Should().Be("XA4QVKM9");
		}

		[Fact]

		public async void Search_InvalidQuery_Fails()
		{
			var result = await Client
				.Company
				.GetFilingHistoryByIdAsync("xyzzzzzzzzzzzzz", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.TotalResults.Should().Be(0);
		}
	}
}