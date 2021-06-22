using FluentAssertions;
using Microsoft.Extensions.Options;
using Uk.CompaniesHouse.Api.Data.Company;
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
				.Company
				.GetOfficerInformationAppointmentAsync("06982102", default, "d_YAc-47aoTmbILKPRY7VukqF-I")
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.Should().BeOfType<Appointment>();

			result.Name.Should().Be("BOND, David Niel Marshall");
			result.Nationality.Should().Be("British");
			result.Occupation.Should().Be("Director");
			result.CountryOfResidence.Should().Be("England");

			var address = result.Address;
			address.AddressLine1.Should().Be("Heywood Avenue");
			address.Country.Should().Be("United Kingdom");
			address.PostalCode.Should().Be("SL6 3JA");
			address.Region.Should().Be("Berkshire");

			var dob = result.DateOfBirth;
			dob.Month.Should().Be("2");
			dob.Year.Should().Be("1975");
		}

		[Fact]

		public async void Search_InvalidQuery_Fails()
		{
			var result = await Client
				.Search
				.GetCompanyInfoByNameAsync("xyzzzzzzzzzzzzz", default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			result.TotalResults.Should().Be(0);
		}
	}
}
