
using System.Data.Entity;

namespace LightPoint.Data.SQL.SQLSystemUnitOfWork
{
    public class SQLSystemDatabaseUnitOfWork : ISQLUnitOfWork
    {
        private DbContext myDbContext;

        public SQLSystemDatabaseUnitOfWork()
        {
            myDbContext = new LightPointEntitiesContext();
        }

        public DbContext MYDbContext
        {
            get
            {
                return myDbContext;
            }
        }


        public void Dispose()
        {
            //myDbContext.Dispose();

            UnitOfWork.UnitOfWork.DisposeUnitOfWork(this);
        }
    }
}
