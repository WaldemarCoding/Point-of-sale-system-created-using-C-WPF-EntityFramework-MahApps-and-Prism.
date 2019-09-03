using PoS.BL.Service;
using PoS.BL.Service.Internal;
using PoS.Dal.Sql.Ctx;

namespace PoS.BL
{
	public class UnitRegistrationBL
	{
		public static void Setup(IUnityContainer container)
		{
			UnityRegistrationDbCtx.Setup(container);
			container.RegisterType<ISecurityService, SecurityService>();
			container.RegisterType<IInventoryService, InventoryService>();
		}
	}
}
