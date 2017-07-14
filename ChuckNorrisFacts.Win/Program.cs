using System;
using System.Windows.Forms;
using ChuckNorrisFacts.Win.Cofniguration;
using Unity;

namespace ChuckNorrisFacts.Win
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = CreateContainer()
				.WithHttpClient()
				.WithForms()
				.WithControllers();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(container.Resolve<Form>());
		}

		private static IUnityContainer CreateContainer() => new UnityContainer();
	}
}
