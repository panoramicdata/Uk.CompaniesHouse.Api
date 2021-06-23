using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class OfficerSearchTests : TestBase
	{
		public OfficerSearchTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Search
				.GetOfficerInfoByNameAsync("David Niel Bond", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.TotalResults.Should().NotBe(0);

			var item = result.Items[0];

			item.Title.Should().Be("David Niel Marshall BOND");

			var address = item.Address;
			address.AddressLine1.Should().Be("Heywood Avenue");
			address.Country.Should().Be("England");
			address.PostalCode.Should().Be("SL6 3JA");
			address.Region.Should().Be("Berkshire");

			var dob = item.DateOfBirth;
			dob.Month.Should().Be("2");
			dob.Year.Should().Be("1975");
		}

		[Fact]

		public async void Search_InvalidQuery_Fails()
		{
			var result = await Client
				.Search
				.GetOfficerInfoByNameAsync("xyzzzzzzzzzzzzz", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.TotalResults.Should().Be(0);
		}
	}
}