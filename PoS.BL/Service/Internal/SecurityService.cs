using PoS.BL.Service.Base;
using PoS.Dal.Mdl;
using PoS.Dal.Sql.Ctx;
using System.Collections.Generic;
using System.Linq;

namespace PoS.BL.Service.Internal
{
	internal class SecurityService: AbstractService, ISecurityService
	{
		public SecurityService(IPosUnitOfWork unitofwork)
			: base (unitofwork)
		{
		}

		public List<User> GetAllUsers()
		{
			return _uofw.UserRepo.GetAll().ToList();
		}

		public User Login(string username, string password)
		{
			return _uofw.UserRepo.GetAll().Where(u => u.UserName == username && u.Password == password).FirstOrDefault();
		}
	}
}
