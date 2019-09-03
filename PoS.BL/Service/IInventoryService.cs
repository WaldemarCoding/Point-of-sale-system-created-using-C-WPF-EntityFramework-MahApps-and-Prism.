using PoS.BL.Models;
using System.Collections.Generic;

namespace PoS.BL.Service
{
	public interface IInventoryService
	{
		List<ProductModel> GetAllProducts();
		ProductModel GetProductByBarCode(string iCode);

		void UpdateProduct (ProductModel iProduct);
		void AddProduct (ProductModel iProduct);

		void DeleteProduct (ProductModel iProduct);
	}
}
