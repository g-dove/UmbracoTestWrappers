using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Gibe.UmbracoWrappers
{
	public class UmbracoWrappersComposer : IUserComposer
	{
		public void Compose(Composition composition)
		{
			composition.RegisterUnique<IUmbracoWrapper, DefaultUmbracoWrapper>();
		}
	}
}
