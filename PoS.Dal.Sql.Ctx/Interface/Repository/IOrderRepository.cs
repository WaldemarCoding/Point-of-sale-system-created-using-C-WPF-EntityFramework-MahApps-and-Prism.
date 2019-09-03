using PoS.Dal.Mdl;
using System.Collections.Generic;

namespace PoS.Dal.Sql.Ctx
{
	public interface IOrderRepository: IPosBaseRepository<Order>
	{
		IEnumerable<Order> GetOrdersByOrderLineId(int orderLineId);
	}
}
