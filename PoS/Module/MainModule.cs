using PoS.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PoS.Module
{
    public class MainModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeTilesView>();
            containerRegistry.RegisterForNavigation<InventoryMainView>();
            containerRegistry.RegisterForNavigation<SecurityMainView>();

        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate("MainRegion", nameof(HomeTilesView));
        }
    }
}
