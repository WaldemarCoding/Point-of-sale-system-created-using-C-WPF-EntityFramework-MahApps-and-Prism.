using PoS.Dal.Mdl;

namespace PoS.Dal.Sql.Ctx
{
	public interface IUserRepository: IPosBaseRepository<User>
	{
		User GetUserByUserName(string iUserName);
		bool LogIn(string iUsername, string iPass);
	}
}
