using FluentAssertions;
using Microsoft.Extensions.Options;
using Xunit;
using Xunit.Abstractions;

namespace Uk.CompaniesHouse.Api.Test
{
	public class InsolvencyTests : TestBase
	{
		public InsolvencyTests(ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		private readonly string ExampleCompanyID = "00229606";

		[Fact]
		public async void Search_ValidQuery_Succeeds()
		{
			var result = await Client
				.Company
				.GetInsolvencyByIdAsync(ExampleCompanyID, default)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
			var caseOne = result.Cases[0];
			var Pract = caseOne.Practitioners[0];
			var Address = Pract.Address;
			var Dates = caseOne.Dates[0];

			Address.AddressLine1.Should().Be("15 Canada Square");
			Address.Locality.Should().Be("London");

			Pract.Name.Should().Be("William James Wright");

			caseOne.Type.Should().Be("corporate-voluntary-arrangement");

			Dates.Type.Should().Be("voluntary-arrangement-started-on");
		}
	}
}