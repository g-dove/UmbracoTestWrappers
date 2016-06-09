using Umbraco.Web;

namespace Gibe.UmbracoWrappers
{
	public class DefaultUmbracoHelperWrapper : IUmbracoHelperWrapper
	{
		private readonly IUmbracoWrapper _umbracoWrapper;

		public DefaultUmbracoHelperWrapper(
			IUmbracoWrapper umbracoWrapper)
		{
			_umbracoWrapper = umbracoWrapper;
		}

		public UmbracoHelper UmbracoHelper()
		{
			return new UmbracoHelper(_umbracoWrapper.CurrentUmbracoContext());
		}

		public string GetPreValueAsString(int id)
		{
			var helper = UmbracoHelper();

			return helper.GetPreValueAsString(id);
		}
	}
}