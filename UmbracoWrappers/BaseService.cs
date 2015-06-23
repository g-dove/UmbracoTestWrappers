using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gibe.UmbracoWrappers
{
	public class BaseService
	{
		public BaseService(IUmbracoWrapper umbracoWrapper)
		{
			UmbracoWrapper = umbracoWrapper;
		}

		protected IUmbracoWrapper UmbracoWrapper { get; set; }
	}
}
