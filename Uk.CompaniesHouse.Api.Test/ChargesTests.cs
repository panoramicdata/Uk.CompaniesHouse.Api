using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class ChargesTests : TestBase
	{
		public ChargesTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetChargesByIdAsync("03034606", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();

			var item = result.Items[0];
			var personsEntitled = item.PersonsEntitled[0];
			var trActions = item.Transactions[0];
			var classification = item.Classification;
			var particulars = item.Particulars;

			personsEntitled.Name.Should().Be("Wilmington Trust Sp Services (Dublin) Limited");

			trActions.DeliveredOn.Should().Be("2021-01-22");
			trActions.FilingType.Should().Be("create-charge-with-deed");

			classification.Description.Should().Be("A registered charge");

			particulars.ContainsFixedCharge.Should().Be(true);

			item.Status.Should().Be("outstanding");
			item.ChargeCode.Should().Be("030346060229");
		}
	}
}