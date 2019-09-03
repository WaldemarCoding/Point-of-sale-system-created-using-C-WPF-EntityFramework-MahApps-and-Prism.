using PoS.Dal.Mdl;
using System.Linq;

namespace PoS.Dal.Sql.Ctx.Repository
{
	public class EmployeeRepository : PoSBaseRepository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository (IPoSContext context) 
			: base (context)
		{

		}

		public Employee GetEmployeeByEmpCode (string code)
		{
			return _dbSet.FirstOrDefault(e => e.EmpCode == code);
		}
	}
}
