namespace PoS.Dal.Sql.Ctx
{
	public interface IPosUnitOfWork
	{
		IEmployeeRepository EmployeeRepo { get; }
		IUserRepository UserRepo { get; }
		IProductRepository ProductRepo { get; }
		IOrderRepository OrderRepo { get; }
		IOrderLineRepository OrderLineRepo { get; }

		int Commit();
	}
}
