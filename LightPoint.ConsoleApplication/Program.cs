using System;
using System.Linq;

using LightPoint.Domain.Entities;
using LightPoint.Service;
using LightPoint.ServiceLocator;
using LightPoint.Domain.Services;


namespace LightPoint.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Register Existing Services
            ServiceLocator.RegisterService<IShopService>(typeof(ShopService));

            ServiceLocator.RegisterService<IGoodsService>(typeof(GoodsService));

            ////Configuration of Database 
            ////Work with file database, uncomment if need and comment the SQL factory.
            ////Data.Context.Current.RepositoryFactory = new RepositoryFactory();

            //UnitOfWork.Context.Current.UnitOfWorkFactory = new FileSystemDatabaseUnitOfWorkFactory();

            //Configuration of Database
            //Work with SQL Database,if need work with file database need to comment Factory;
            Data.Context.Current.RepositoryFactory = new Data.SQL.RepositoryFactory();

            UnitOfWork.Context.Current.UnitOfWorkFactory = new Data.SQL.SQLSystemUnitOfWork.SQLSystemDatabaseUnitofWorkFactory();



        }
    }
}
