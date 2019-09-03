using PoS.Dal.Mdl;
using System.Collections.Generic;

namespace PoS.Dal.Sql.Ctx
{
	public interface IProductRepository: IPosBaseRepository<Product>
	{
		IEnumerable<Product> GetProductByStockType(EStockType iStockTye);
		Product GetProductByCode(string barcode);
	}
}
