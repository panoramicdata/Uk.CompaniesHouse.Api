using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class DisqualifiedOfficerNaturalSearchTests : TestBase
	{
		public DisqualifiedOfficerNaturalSearchTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		private readonly string ExampleOfficerID = "Xnyu-NIsDtgtZDK42JJJ567Lixc";

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetNaturalDisqualifiedByIdAsync(ExampleOfficerID, default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();

			var Dis = result.Disqualifications[0];
			Dis.DisqualifiedUntil.Should().Be("2027-05-06");
			Dis.CaseIdentifier.Should().Be("INV3412423");

			var Addr = Dis.Address;
			Addr.Locality.Should().Be("London");

			result.Nationality.Should().Be("British");
			result.Forename.Should().Be("Dominic");
		}
	}
}