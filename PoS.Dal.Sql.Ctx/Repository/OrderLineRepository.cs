using PoS.Dal.Mdl;

namespace PoS.Dal.Sql.Ctx.Repository
{
	public class OrderLineRepository : PoSBaseRepository<OrderLine>, IOrderLineRepository
	{
		public OrderLineRepository(IPoSContext context)
			: base(context)
		{
		}
	}
}
