using PoS.Dal.Sql.Ctx.Context;
using PoS.Dal.Sql.Ctx.Repository;
using PoS.Dal.Sql.Ctx.Transaction;

namespace PoS.Dal.Sql.Ctx
{
	public class UnityRegistrationDbCtx
	{
		public static void Setup(IUnityContainer container)
		{
			container.RegisterType<IPoSContext, PoSContext>();
			container.RegisterType<IPosUnitOfWork, PoSUnitOfWork>();
			container.RegisterType<IUserRepository, UserRepository>();
			container.RegisterType<IProductRepository, ProductRepository>();
		}
	}
}
