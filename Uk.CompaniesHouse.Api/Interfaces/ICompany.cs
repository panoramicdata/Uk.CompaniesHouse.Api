using Refit;
using System.Threading;
using System.Threading.Tasks;
using Uk.CompaniesHouse.Api.Data.Charges;
using Uk.CompaniesHouse.Api.Data.Company;
using Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerCorporate;
using Uk.CompaniesHouse.Api.Data.DisqualifiedOfficerNatural;
using Uk.CompaniesHouse.Api.Data.Exemptions;
using Uk.CompaniesHouse.Api.Data.Filing_History;
using Uk.CompaniesHouse.Api.Data.Insolvency;
using Uk.CompaniesHouse.Api.Data.Officers;
using Uk.CompaniesHouse.Api.Data.Persons_with_Significant_Control;
using Uk.CompaniesHouse.Api.Data.Registers;
using Uk.CompaniesHouse.Api.Data.UkEstablishments;

namespace Uk.CompaniesHouse.Api.Interfaces;

public interface ICompany
{
	/// <summary>
	/// Find company information from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}")]
	public Task<Company> GetByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find address information from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/registered-office-address")]
	public Task<RegisteredOfficeAddress> GetRegisteredAddressAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find officer list from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/officers")]
	public Task<OfficerList> GetOfficerListByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find officer information from the appointment number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="appointmentNumber">The appointment number</param>
	[Get("/company/{companyNumber}/appointments/{appointmentNumber}")]
	public Task<Officer> GetOfficerInformationByAppointmentAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("appointmentNumber")] string appointmentNumber
		);

	/// <summary>
	/// Find register information from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/registers")]
	public Task<RegistersMain> GetRegisterInfoByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find filing history information from the company number and transaction ID
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="transactionID">The transaction ID</param>
	[Get("/company/{companyNumber}/filing-history/{transactionID}")]
	public Task<FilingHistory> GetFilingHistoryByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("transactionID")] string transactionID
		);

	/// <summary>
	/// Find filing history list from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/filing-history")]
	public Task<FilingHistoryList> GetFilingHistoryListByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find details of natural disqualified officer from officer ID
	/// </summary>
	/// <param name="officerID">The officer ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/disqualified-officers/natural/{officer_id}")]
	public Task<DisqualifiedOfficerNatural> GetNaturalDisqualifiedByIdAsync(
		[AliasAs("officer_id")] string officerID,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find details of corporate disqualified officer from officer ID
	/// </summary>
	/// <param name="officerID">The officer ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/disqualified-officers/corporate/{officer_id}")]
	public Task<DisqualifiedOfficerCorporate> GetCorporateDisqualifiedByIdAsync(
		[AliasAs("officer_id")] string officerID,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find details of UK establishments from company ID
	/// </summary>
	/// <param name="companyNumber">The officer ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/uk-establishments")]
	public Task<UkEstablishments> GetUkEstablishmentsByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find details of charges from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/charges")]
	public Task<ChargesListMain> GetChargesListByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find charges info from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="chargeID">The charge ID</param>"
	[Get("/company/{companyNumber}/charges/{chargeID}")]
	public Task<Charges> GetChargesByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("chargeID")] string chargeID
		);

	/// <summary>
	/// Find details of insolvency from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/insolvency")]
	public Task<InsolvencyMain> GetInsolvencyByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find details of exemptions from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/exemptions")]
	public Task<ExemptionsMain> GetExemptionsByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find corporate entity with significant control from the company number and psc id
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="pscID">The psc ID</param>"
	[Get("/company/{companyNumber}/persons-with-significant-control/corporate-entity/{pscID}")]
	public Task<CorporateEntity> GetCorporateEntityByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("pscID")] string pscID
		);

	/// <summary>
	/// Find individual with significant control from the company number and psc id
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="pscID">The psc ID</param>"
	[Get("/company/{companyNumber}/persons-with-significant-control/individual/{pscID}")]
	public Task<Individual> GetIndividualByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("pscID")] string pscID
		);

	/// <summary>
	/// Find legal person with significant control from the company number and psc id
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="pscID">The psc ID</param>"
	[Get("/company/{companyNumber}/persons-with-significant-control/legal-person/{pscID}")]
	public Task<LegalPerson> GetLegalPersonByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("pscID")] string pscID
		);

	/// <summary>
	/// Find PSC statement from the company number and statement id
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="statementID">The psc ID</param>"
	[Get("/company/{companyNumber}/persons-with-significant-control-statements/{statementID}")]
	public Task<Statement> GetStatementByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("statementID")] string statementID
		);

	/// <summary>
	/// Find super secure person details from the company number and super secure ID
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	/// <param name="superSecureID">The super secure ID</param>"
	[Get("/company/{companyNumber}/persons-with-significant-control/super-secure/{superSecureID}")]
	public Task<SuperSecure> GetSuperSecureByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken,
		[AliasAs("superSecureID")] string superSecureID
		);

	/// <summary>
	/// Find persons with significant control list from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/persons-with-significant-control")]
	public Task<PWSCList> GetPWSCListByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);

	/// <summary>
	/// Find statement list from the company number
	/// </summary>
	/// <param name="companyNumber">The company number</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/company/{companyNumber}/persons-with-significant-control-statements")]
	public Task<StatementList> GetStatementListByIdAsync(
		[AliasAs("companyNumber")] string companyNumber,
		CancellationToken cancellationToken
		);
}