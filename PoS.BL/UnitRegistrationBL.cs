using PoS.BL.Service;
using PoS.BL.Service.Internal;
using PoS.Dal.Sql.Ctx;
using Prism.Ioc;

namespace PoS.BL
{
	public class UnitRegistrationBL
	{
		public static void Setup(IContainerRegistry container)
		{
			UnityRegistrationDbCtx.Setup(container);
			container.Register<ISecurityService, SecurityService>();
			container.Register<IInventoryService, InventoryService>();
		}
	}
}
