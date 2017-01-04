using System.Collections.Generic;
using Examine;
using Examine.Providers;
using Examine.SearchCriteria;

namespace Gibe.UmbracoWrappers
{
	public class ExamineSearchWrapper : IExamineSearchWrapper
	{
		public BaseSearchProvider InternalSearcher()
		{
			return ExamineManager.Instance.SearchProviderCollection["ExternalSearcher"];
		}

		public BaseSearchProvider ExternalSearcher()
		{
			return ExamineManager.Instance.SearchProviderCollection["InternalSearcher"];
		}

		public BaseSearchProvider Searcher(string key)
		{
			return ExamineManager.Instance.SearchProviderCollection[key];
		}

		public ISearchCriteria CreateSearchCriteria(BaseSearchProvider searcher)
		{
			return searcher.CreateSearchCriteria();
		}

		public ISearchCriteria Compile(IBooleanOperation criteria)
		{
			return criteria.Compile();
		}

		public ISearchCriteria RawQuery(ISearchCriteria criteria, string query)
		{
			return criteria.RawQuery(query);
		}

		public IBooleanOperation Field(ISearchCriteria criteria, string fieldName, IExamineValue fieldValue)
		{
			return criteria.Field(fieldName, fieldValue);
		}

		public IBooleanOperation Field(ISearchCriteria criteria, string fieldName, string fieldValue)
		{
			return criteria.Field(fieldName, fieldValue);
		}

		public IBooleanOperation GroupedOr(ISearchCriteria criteria, IEnumerable<string> fields, params IExamineValue[] query)
		{
			return criteria.GroupedOr(fields, query);
		}

		public IBooleanOperation GroupedOr(ISearchCriteria criteria, IEnumerable<string> fields, params string[] query)
		{
			return criteria.GroupedOr(fields, query);
		}

		public IBooleanOperation GroupedAnd(ISearchCriteria criteria, IEnumerable<string> fields, params IExamineValue[] query)
		{
			return criteria.GroupedAnd(fields, query);
		}

		public IBooleanOperation GroupedAnd(ISearchCriteria criteria, IEnumerable<string> fields, params string[] query)
		{
			return criteria.GroupedAnd(fields, query);
		}

		public IQuery And(IBooleanOperation operation)
		{
			return operation.And();
		}

		public IQuery Or(IBooleanOperation operation)
		{
			return operation.Or();
		}

		public IQuery Not(IBooleanOperation operation)
		{
			return operation.Not();
		}

		public ISearchResults Search(BaseSearchProvider searcher, ISearchCriteria criteria)
		{
			return searcher.Search(criteria);
		}
	}
}