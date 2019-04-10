using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Composing;

namespace Gibe.UmbracoWrappers
{
	public class UmbracoWrappersComposer : IComposer
	{
		public void Compose(Composition composition)
		{
			composition.RegisterFor<IUmbracoWrapper, DefaultUmbracoWrapper>();
		}
	}
}
