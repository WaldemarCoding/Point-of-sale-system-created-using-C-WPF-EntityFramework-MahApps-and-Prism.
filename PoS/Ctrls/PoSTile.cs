using MahApps.Metro.Controls;
using PoS.Dal.Mdl;

namespace PoS.Ctrls
{
	public class PoSTile: Tile
	{
		private ERoleType _roletype;
		public ERoleType RoleType
		{
			get
			{
				return _roletype;
			}
			set
			{
				if (_roletype != value) {
					_roletype = value;
				}
			}
		}

		private string _viewname;
		public string ViewName
		{
			get
			{
				return _viewname;
			}
			set
			{
				if (_viewname != value) {
					_viewname = value;
				}
			}
		}
	}
}
