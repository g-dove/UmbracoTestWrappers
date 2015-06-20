using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace UmbracoTestWrappers
{
	public class BaseRenderMvcController : RenderMvcController
  {
		public BaseRenderMvcController(IUmbracoHelper umbracoHelper) : base(umbracoHelper.CurrentUmbracoContext())
		{
			Umbraco = umbracoHelper;
		}

		protected IUmbracoHelper Umbraco { get; set; }
  }
}
