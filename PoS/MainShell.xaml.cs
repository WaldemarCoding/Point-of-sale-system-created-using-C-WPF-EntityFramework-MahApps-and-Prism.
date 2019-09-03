using MahApps.Metro.Controls;
using Prism.Regions;
using System.Windows;

namespace PoS
{
	/// <summary>
	/// Interaction logic for MainShell.xaml
	/// </summary>
	public partial class MainShell : MetroWindow
	{
		IRegionManager mRegionManager;
		public MainShell (IRegionManager regionManager)
		{
			InitializeComponent ();

			mRegionManager = regionManager;

			if(mRegionManager != null) {
			}
		}

		/// <summary>
		/// Set Region Manager
		/// </summary>
		/// <param name="regionManager">[in] Region Manager</param>
		/// <param name="regionTarget">[in] Region Target</param>
		/// <param name="regionName">[in] Region Name</param>
		private void SetRegionManager (IRegionManager regionManager,
									   DependencyObject regionTarget,
									   string regionName)
		{
			RegionManager.SetRegionName (regionTarget, regionName);
			RegionManager.SetRegionManager (regionTarget, regionManager);
		}
	}
}
