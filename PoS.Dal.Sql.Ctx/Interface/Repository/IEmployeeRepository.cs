using PoS.Dal.Mdl;

namespace PoS.Dal.Sql.Ctx
{
	public interface IEmployeeRepository:IPosBaseRepository<Employee>
	{
		Employee GetEmployeeByEmpCode(string code);
	}
}
