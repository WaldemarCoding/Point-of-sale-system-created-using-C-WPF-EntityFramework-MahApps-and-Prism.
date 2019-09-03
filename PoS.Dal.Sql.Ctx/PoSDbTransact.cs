using PoS.Dal.Sql.Ctx.Context;
using PoS.Dal.Sql.Ctx.Transaction;

namespace PoS.Dal.Sql.Ctx
{
	public class PoSDbTransact
	{
		private PoSContext _context;
		private PoSUnitOfWork _unitofwork;

		public IPoSContext DbContext
		{
			get
			{
				return _context;
			}
		}

		public IPosUnitOfWork UnitOfWork
		{
			get
			{
				return _unitofwork;
			}
		}

		public PoSDbTransact(string connstring)
		{
			_context = new PoSContext();
			_unitofwork = new PoSUnitOfWork(_context);
		}
	}
}
