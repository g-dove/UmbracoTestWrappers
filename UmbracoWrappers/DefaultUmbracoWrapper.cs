﻿using System.Collections.Generic;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Gibe.UmbracoWrappers
{
	public class DefaultUmbracoWrapper : IUmbracoWrapper
	{
		public IPublishedContent Descendant(IPublishedContent content)
		{
			return content.Descendant();
		}

		public IPublishedContent Descendant(IPublishedContent content, int level)
		{
			return content.Descendant(level);
		}

		public IPublishedContent Descendant(IPublishedContent content, string contentTypeAlias)
		{
			return content.Descendant(contentTypeAlias);
		}

		public IPublishedContent DescendantOrSelf(IPublishedContent content)
		{
			return content.DescendantOrSelf();
		}

		public IPublishedContent DescendantOrSelf(IPublishedContent content, int level)
		{
			return content.DescendantOrSelf(level);
		}

		public IPublishedContent DescendantOrSelf(IPublishedContent content, string contentTypeAlias)
		{
			return content.DescendantOrSelf(contentTypeAlias);
		}

		public IEnumerable<IPublishedContent> Descendants(IPublishedContent content)
		{
			return content.Descendants();
		}

		public IEnumerable<IPublishedContent> Descendants(IPublishedContent content, int level)
		{
			return content.Descendants(level);
		}

		public IEnumerable<IPublishedContent> Descendants(IPublishedContent content, string contentTypeAlias)
		{
			return content.Descendants(contentTypeAlias);
		}

		public IEnumerable<IPublishedContent> DescendantsOrSelf(IPublishedContent content)
		{
			return content.DescendantsOrSelf();
		}

		public IEnumerable<IPublishedContent> DescendantsOrSelf(IPublishedContent content, int level)
		{
			return content.DescendantsOrSelf(level);
		}

		public IEnumerable<IPublishedContent> DescendantsOrSelf(IPublishedContent content, string contentTypeAlias)
		{
			return content.DescendantsOrSelf(contentTypeAlias);
		}

		public bool IsDescendant(IPublishedContent content, IPublishedContent other)
		{
			return content.IsDescendant(other);
		}

		public bool IsDescendantOrSelf(IPublishedContent content, IPublishedContent other)
		{
			return content.IsDescendantOrSelf(other);
		}

		public IPublishedContent Ancestor(IPublishedContent content)
		{
			return content.Ancestor();
		}

		public IPublishedContent Ancestor(IPublishedContent content, int maxLevel)
		{
			return content.Ancestor(maxLevel);
		}

		public IPublishedContent Ancestor(IPublishedContent content, string contentTypeAlias)
		{
			return content.Ancestor(contentTypeAlias);
		}

		public IPublishedContent AncestorOrSelf(IPublishedContent content)
		{
			return content.AncestorOrSelf();
		}

		public IPublishedContent AncestorOrSelf(IPublishedContent content, int maxLevel)
		{
			return content.AncestorOrSelf(maxLevel);
		}

		public IPublishedContent AncestorOrSelf(IPublishedContent content, string contentTypeAlias)
		{
			return content.AncestorOrSelf(contentTypeAlias);
		}

		public IEnumerable<IPublishedContent> Ancestors(IPublishedContent content)
		{
			return content.Ancestors();
		}

		public IEnumerable<IPublishedContent> Ancestors(IPublishedContent content, int maxLevel)
		{
			return content.Ancestors(maxLevel);
		}

		public IEnumerable<IPublishedContent> Ancestors(IPublishedContent content, string contentTypeAlias)
		{
			return content.Ancestors(contentTypeAlias);
		}

		public IEnumerable<IPublishedContent> AncestorsOrSelf(IPublishedContent content)
		{
			return content.AncestorsOrSelf();
		}

		public IEnumerable<IPublishedContent> AncestorsOrSelf(IPublishedContent content, int maxLevel)
		{
			return content.AncestorsOrSelf(maxLevel);
		}

		public IEnumerable<IPublishedContent> AncestorsOrSelf(IPublishedContent content, string contentTypeAlias)
		{
			return content.AncestorsOrSelf(contentTypeAlias);
		}
		
		public bool IsAncestor(IPublishedContent content, IPublishedContent ancestor)
		{
			return content.IsAncestor(ancestor);
		}

		public bool IsAncestorOrSelf(IPublishedContent content, IPublishedContent ancestor)
		{
			return content.IsAncestorOrSelf(ancestor);
		}

		public T Value<T>(IPublishedContent content, string alias)
		{
			return content.Value<T>(alias);
		}

		public bool HasProperty(IPublishedContent content, string alias)
		{
			return content.HasProperty(alias);
		}

		public bool HasValue(IPublishedContent content, string alias)
		{
			return content.HasValue(alias);
		}

		public bool IsVisible(IPublishedContent content)
		{
			return content.IsVisible();
		}

		public string UrlAbsolute(IPublishedContent content)
		{
			return content.UrlAbsolute();
	}
	}
}
