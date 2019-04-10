using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examine.Providers;
using Examine.Search;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Gibe.UmbracoWrappers
{
	public interface IUmbracoWrapper
	{
		IPublishedContent Descendant(IPublishedContent content);
		IPublishedContent Descendant(IPublishedContent content, int level);
		IPublishedContent Descendant(IPublishedContent content, string contentTypeAlias);

		IPublishedContent DescendantOrSelf(IPublishedContent content);
		IPublishedContent DescendantOrSelf(IPublishedContent content, int level);
		IPublishedContent DescendantOrSelf(IPublishedContent content, string contentTypeAlias);

		IEnumerable<IPublishedContent> Descendants(IPublishedContent content);
		IEnumerable<IPublishedContent> Descendants(IPublishedContent content, int level);
		IEnumerable<IPublishedContent> Descendants(IPublishedContent content, string contentTypeAlias);

		IEnumerable<IPublishedContent> DescendantsOrSelf(IPublishedContent content);
		IEnumerable<IPublishedContent> DescendantsOrSelf(IPublishedContent content, int level);
		IEnumerable<IPublishedContent> DescendantsOrSelf(IPublishedContent content, string contentTypeAlias);

		bool IsDescendant(IPublishedContent content, IPublishedContent other);
		bool IsDescendantOrSelf(IPublishedContent node, IPublishedContent other);

		IPublishedContent Ancestor(IPublishedContent content);
		IPublishedContent Ancestor(IPublishedContent content, int maxLevel);
		IPublishedContent Ancestor(IPublishedContent content, string contentTypeAlias);

		IPublishedContent AncestorOrSelf(IPublishedContent content);
		IPublishedContent AncestorOrSelf(IPublishedContent content, int maxLevel);
		IPublishedContent AncestorOrSelf(IPublishedContent content, string contentTypeAlias);
		
		IEnumerable<IPublishedContent> Ancestors(IPublishedContent content);
		IEnumerable<IPublishedContent> Ancestors(IPublishedContent content, int maxLevel);
		IEnumerable<IPublishedContent> Ancestors(IPublishedContent content, string contentTypeAlias);

		IEnumerable<IPublishedContent> AncestorsOrSelf(IPublishedContent content);
		IEnumerable<IPublishedContent> AncestorsOrSelf(IPublishedContent content, int maxLevel);
		IEnumerable<IPublishedContent> AncestorsOrSelf(IPublishedContent content, string contentTypeAlias);

		bool IsAncestor(IPublishedContent content, IPublishedContent ancestor);
		bool IsAncestorOrSelf(IPublishedContent content, IPublishedContent ancestor);

		T Value<T>(IPublishedContent content, string alias);

		bool HasProperty(IPublishedContent content, string alias);
		bool HasValue(IPublishedContent content, string alias);

		bool IsVisible(IPublishedContent content);
		string UrlAbsolute(IPublishedContent content);

	}
}
