using PoS.Dal.Sql.Ctx.Context;
using PoS.Dal.Sql.Ctx.Repository;
using PoS.Dal.Sql.Ctx.Transaction;
using Prism.Ioc;

namespace PoS.Dal.Sql.Ctx
{
	public class UnityRegistrationDbCtx
	{
		public static void Setup(IContainerRegistry container)
		{
			container.Register<IPoSContext, PoSContext>();
			container.Register<IPosUnitOfWork, PoSUnitOfWork>();
			container.Register<IUserRepository, UserRepository>();
			container.Register<IProductRepository, ProductRepository>();
		}
	}
}
