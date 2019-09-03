﻿using PoS.BL.Service;
using PoS.BL.Service.Internal;
using PoS.Dal.Sql.Ctx;

namespace PoS.BL
{
	public static class TServiceFactory
	{
		private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PoSDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		private static PoSDbTransact mTransact;
		private static ISecurityService mSecurityService;
		private static IInventoryService mInventoryService;

		private static IPosUnitOfWork GetUnitOfWork()
		{
			if (mTransact == null)
			{
				mTransact = new PoSDbTransact("PosDbMySql");
			}

			return mTransact.UnitOfWork;
		}

		public static ISecurityService GetSecurityService()
		{
			if (mSecurityService == null)
			{
				mSecurityService = new SecurityService(GetUnitOfWork());
			}

			return mSecurityService;
		}

		public static IInventoryService GetInventoryService(string iUserName)
		{

			return mInventoryService;
		}
	}
}
