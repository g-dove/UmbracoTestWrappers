using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoTestWrappers
{
	public class BaseService
	{
		public BaseService(IUmbracoHelper umbracoHelper)
		{
			Umbraco = umbracoHelper;
		}

		protected IUmbracoHelper Umbraco { get; set; }
	}
}
