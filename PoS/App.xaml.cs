using System.Windows;

namespace PoS
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup (StartupEventArgs e)
		{
			base.OnStartup (e);

			MainBootstrapper boot =new MainBootstrapper();

			boot.Run ();
		}
	}
}
