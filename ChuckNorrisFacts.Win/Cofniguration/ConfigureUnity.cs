using System.Net.Http;
using System.Windows.Forms;
using ChuckNorrisFacts.Win.Controllers;
using Unity;

namespace ChuckNorrisFacts.Win.Cofniguration
{
	public static class ConfigureUnity
	{
		public static IUnityContainer WithForms(this IUnityContainer container)
		{
			container.RegisterType<Form, MainForm>();
			return container;
		}

		public static IUnityContainer WithHttpClient(this IUnityContainer container)
		{
			container.RegisterInstance(new HttpClient());
			return container;
		}

		public static IUnityContainer WithControllers(this IUnityContainer container)
		{
			container.RegisterType<FactsGathererController, FactsGathererController>();
			return container;
		}
	}
}
