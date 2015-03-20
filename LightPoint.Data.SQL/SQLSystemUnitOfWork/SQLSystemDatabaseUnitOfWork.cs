
using System.Data.Entity;

namespace LightPoint.Data.SQL.SQLSystemUnitOfWork
{


    public class SQLSystemDatabaseUnitOfWork : ISQLUnitOfWork
    {
        private DbContext myDbContext;

        public DbContext MYDbContext
        {
            get
            {
                return myDbContext;
            }
        }

        /// Constructor
        /// </summary>
        /// <param name="unitofworkfactory"></param>
        public SQLSystemDatabaseUnitOfWork(SQLSystemDatabaseUnitofWorkFactory unitofworkfactory)
        {
            myDbContext = new LightPointEntitiesContext();
        }
        /// <summary>
        /// Free all resources and close current Unit of Work.
        /// </summary>
        public void Dispose()
        {
            myDbContext.Dispose();
            //TODO
            //rework
            UnitOfWork.UnitOfWork.DisposeUnitOfWork(this);
        }
    }
}
