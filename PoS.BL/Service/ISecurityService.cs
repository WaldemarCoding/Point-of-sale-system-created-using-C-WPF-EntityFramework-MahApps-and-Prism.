using PoS.Dal.Mdl;
using System.Collections.Generic;

namespace PoS.BL.Service
{
	public interface ISecurityService
	{
		List<User> GetAllUsers();
		User Login(string username, string password);
	}
}
