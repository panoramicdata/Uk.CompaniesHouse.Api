using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class PersonWithSignificantControlTests : TestBase
	{
		public PersonWithSignificantControlTests(ITestOutputHelper testOutputHelper,
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
				.GetPWSCInfoByIdAsync(ExampleCompanyID, default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();

			var item = result.Items[0];

			item.CountryOfResidence.Should().Be("England");
			item.NotifiedOn.Should().Be("2016-08-05");
			item.NaturesOfControl[0].Should().Be("ownership-of-shares-75-to-100-percent");

			var nameElements = item.NameElements;
			nameElements.MiddleName.Should().Be("Niel Marshall");
			nameElements.Title.Should().Be("Mr");

			var address = item.Address;
			address.Locality.Should().Be("Maidenhead");
			address.AddressLine1.Should().Be("Heywood Avenue");
		}
	}
}