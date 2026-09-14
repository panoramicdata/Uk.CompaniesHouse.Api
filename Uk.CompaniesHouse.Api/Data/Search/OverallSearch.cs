using System.Runtime.Serialization;

namespace Uk.CompaniesHouse.Api.Data.Search;

/// <summary>
/// Base class for search results.
/// </summary>
[DataContract]
public class SearchResults : DisqualifiedOfficerSearchResults
{
}

/// <summary>
/// The results of the completed search.
/// </summary>
[DataContract]
public class OverallSearch : SearchResults
{
}