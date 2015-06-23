using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Gibe.UmbracoWrappers
{
	public class BaseRenderMvcController : RenderMvcController
  {
		public BaseRenderMvcController(IUmbracoWrapper umbracoHelper) : base(umbracoHelper.CurrentUmbracoContext())
		{
			UmbracoWrapper = umbracoHelper;
		}

		protected IUmbracoWrapper UmbracoWrapper { get; set; }
  }
}
