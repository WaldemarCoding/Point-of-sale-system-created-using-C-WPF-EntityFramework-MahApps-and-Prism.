using System.Linq;
using PoS.Dal.Sql.Ctx;

namespace TestDb
{
	class Program
	{
		static void Main (string[] args)
		{
			PoSDbTransact dbTransact = new PoSDbTransact("PosDbConn");

			var users = dbTransact.UnitOfWork.UserRepo.GetAll ().ToList ();
		}
	}
}
