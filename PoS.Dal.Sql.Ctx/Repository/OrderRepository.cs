using PoS.Dal.Mdl;
using System.Collections.Generic;
using System.Linq;

namespace PoS.Dal.Sql.Ctx.Repository
{
	public class OrderRepository : PoSBaseRepository<Order>, IOrderRepository
	{
		public OrderRepository(IPoSContext context) 
			: base(context)
		{

		}

		public IEnumerable<Order> GetOrdersByOrderLineId(int orderLineId)
		{
			return _dbSet.Where(o => o.OrderLineId == orderLineId);
		}
	}
}
