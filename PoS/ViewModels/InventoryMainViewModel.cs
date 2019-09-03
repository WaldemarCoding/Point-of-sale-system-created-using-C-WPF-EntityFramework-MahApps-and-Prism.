using MahApps.Metro.IconPacks;
using PoS.Ctrls;
using PoS.Views;
using System.Collections.ObjectModel;

namespace PoS.ViewModels
{
	public class InventoryMainViewModel:ViewModelBase
	{
		private ObservableCollection<HamburgerMenu> AppMenu = new ObservableCollection<HamburgerMenu>();
		public ObservableCollection<HamburgerMenu> Menu => AppMenu;
		public InventoryMainViewModel ()
		{
			_SetMenuItem ();
		}

		private void _SetMenuItem ()
		{
			Menu.Add (new HamburgerMenu {
				Icon = new PackIconOcticons() { Kind = PackIconOcticonsKind.Package},
				Label = "Inventory",
				Tag = new InventoryDataView()
			});
		}
	}
}
