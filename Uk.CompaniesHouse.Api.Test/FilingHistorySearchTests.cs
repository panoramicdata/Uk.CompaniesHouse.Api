using FluentAssertions;
using Microsoft.Extensions.Options;
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

		private readonly string ExampleCompanyID = "06982102";

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetFilingHistoryListByIdAsync(ExampleCompanyID, default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();

			var item = result.Items[0];

			item.Category.Should().Be("accounts");

			item.Pages.Should().Be(3);
			item.Barcode.Should().Be("XA4QVKM9");
		}

		[Fact]

		public async void Search_InvalidQuery_Fails()
		{
			var result = await Client
				.Company
				.GetFilingHistoryListByIdAsync("xyzzzzzzzzzzzzz", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
		}
	}
}