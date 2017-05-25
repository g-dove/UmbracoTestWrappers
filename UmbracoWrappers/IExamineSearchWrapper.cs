using System.Collections.Generic;
using Examine;
using Examine.Providers;
using Examine.SearchCriteria;

namespace Gibe.UmbracoWrappers
{
	public interface IExamineSearchWrapper
	{
		BaseSearchProvider InternalSearcher();
		BaseSearchProvider ExternalSearcher();
		BaseSearchProvider Searcher(string key);

		#region extension method replacements

		ISearchCriteria CreateSearchCriteria(BaseSearchProvider searcher);
		ISearchCriteria CreateMediaSearchCriteria(BaseSearchProvider searcher);
		ISearchCriteria Compile(IBooleanOperation criteria);
		ISearchCriteria RawQuery(ISearchCriteria criteria, string query);
		IBooleanOperation Field(ISearchCriteria criteria, string fieldName, IExamineValue fieldValue);
		IBooleanOperation Field(ISearchCriteria criteria, string fieldName, string fieldValue);
		IBooleanOperation GroupedOr(ISearchCriteria criteria, IEnumerable<string> fields, params IExamineValue[] query);
		IBooleanOperation GroupedOr(ISearchCriteria criteria, IEnumerable<string> fields, params string[] query);
		IBooleanOperation GroupedAnd(ISearchCriteria criteria, IEnumerable<string> fields, params IExamineValue[] query);
		IBooleanOperation GroupedAnd(ISearchCriteria criteria, IEnumerable<string> fields, params string[] query);
		IQuery And(IBooleanOperation operation);
		IQuery Or(IBooleanOperation operation);
		IQuery Not(IBooleanOperation operation);
		ISearchResults Search(BaseSearchProvider searcher, ISearchCriteria criteria);

		#endregion
	}
}