using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace PoS.Dal.Sql.Ctx.Interface
{
	public interface IDataContextBase
	{
		IDbSet<T> Set<T>() where T: class;
		DbEntityEntry<T> Entry<T>(T entry) where T : class;
	}
}
