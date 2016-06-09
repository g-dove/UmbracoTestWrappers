using Umbraco.Web;

namespace Gibe.UmbracoWrappers
{
	public interface IUmbracoHelperWrapper
	{
		UmbracoHelper UmbracoHelper();

		string GetPreValueAsString(int id);
	}
}