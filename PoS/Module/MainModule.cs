using PoS.Views;
using Prism.Modularity;
using Prism.Regions;

namespace PoS.Module
{
	public class MainModule : IModule
	{
		private IUnityContainer _container;
		private IRegionManager _regionManager;

		public MainModule (IUnityContainer unityContainer, IRegionManager regionManager)
		{
			_container = unityContainer;
			_regionManager = regionManager;
		}
		public void Initialize ()
		{
			_container.RegisterTypeForNavigation<HomeTilesView> ("HomeTilesView");
			_container.RegisterTypeForNavigation<InventoryMainView> ("InventoryMainView");
			_container.RegisterTypeForNavigation<SecurityMainView> ("SecurityMainView");

			_regionManager.RequestNavigate ("MainRegion", "HomeTilesView");
		}
	}
}
