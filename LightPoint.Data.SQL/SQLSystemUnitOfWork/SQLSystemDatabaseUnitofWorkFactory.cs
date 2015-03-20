
using LightPoint.UnitOfWork.Interfaces;

namespace LightPoint.Data.SQL.SQLSystemUnitOfWork
{
    public class SQLSystemDatabaseUnitofWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create()
        {
            return new SQLSystemDatabaseUnitOfWork();
        }
    }
}
