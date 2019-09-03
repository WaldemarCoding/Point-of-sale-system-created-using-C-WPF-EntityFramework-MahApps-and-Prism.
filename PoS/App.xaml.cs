using System.Threading;
using PoS.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using PoS.BL;
using PoS.Module;
using Prism.Regions;

namespace PoS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {

        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);

            Mutex mutex = new Mutex(true, "PoS");

            if (mutex.WaitOne(0, false) == true)
            {
                var regionManager = Container.Resolve<IRegionManager>();

                if (regionManager != null)
                {
                    regionManager.RegisterViewWithRegion("LeftCommandRegion", typeof(HomeCommandView));
                    regionManager.RegisterViewWithRegion("RightCommandRegion", typeof(LoginCommandView));
                    regionManager.RegisterViewWithRegion("FlyoutControlRegion", typeof(LoginFlyOutView));
                    regionManager.RegisterViewWithRegion("FlyoutControlRegion", typeof(UserInfoFlyoutView));
                }

                App.Current.MainWindow.Show();
            }
            else
            {
                App.Current.Shutdown();
            }

            mutex.ReleaseMutex();
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<MainShell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            UnitRegistrationBL.Setup(containerRegistry);
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule(typeof(MainModule));
        }
    }
}