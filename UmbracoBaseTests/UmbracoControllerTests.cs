using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using Umbraco.Core.Models;
using Umbraco.Tests.TestHelpers;
using Umbraco.Web;
using Umbraco.Web.Routing;
using UmbracoTestWrappers;

namespace UmbracoBaseTests
{
	public abstract class UmbracoControllerTests : BaseRoutingTest
	{
		// Pulled from - http://web-matters.blogspot.co.uk/2014/04/unit-testing-umbraco-with-base-test-classes.html
		// but now simpler because 7.2.2 onwards has more publics than previous versions
		protected T SetupController<T>(T controller, IPublishedContent currentPage) where T : BaseRenderMvcController
		{
			// Create contexts via test base class methods
			
			var contextBase = GetUmbracoContext().HttpContext;
			
			// Similarly create instance of PublishedContentRequest
			var publishedContentRequest = new PublishedContentRequest(new Uri("/test", UriKind.Relative), GetRoutingContext())
			{
				PublishedContent = currentPage
			};

			var routeDefinition = new Umbraco.Web.Mvc.RouteDefinition {PublishedContentRequest = publishedContentRequest};

			// Then add it to the route data tht will be passed to the controller context
			// - without it SurfaceController.CurrentPage will throw an exception of: "Cannot find the Umbraco route definition in the route values, the request must be made in the context of an Umbraco request"
			var routeData = new RouteData();
			routeData.DataTokens.Add("umbraco-route-def", routeDefinition);
			
			controller.ControllerContext = new ControllerContext(contextBase, routeData, controller);
			controller.Url = new UrlHelper(new RequestContext(contextBase, new RouteData()), new RouteCollection());
			return controller;
		}

		protected RoutingContext GetRoutingContext()
		{
			return GetRoutingContext("/test");
		}

		protected UmbracoContext GetUmbracoContext()
		{
			return GetRoutingContext().UmbracoContext;
		}

		protected IPublishedContent MockIPublishedContent(
			int id = 1234, 
			string name = "Test Content",
			string docTypeAlias = "Page",
			IEnumerable<IPublishedContent> children = null)
		{
			var mock = new Mock<IPublishedContent>();
			mock.Setup(x => x.Id).Returns(id);
			mock.Setup(x => x.Name).Returns(name);
			mock.Setup(x => x.DocumentTypeAlias).Returns(docTypeAlias);
			if (children != null)
			{
				mock.Setup(x => x.Children).Returns(children);
			}
			return mock.Object;
		}

	}
}
