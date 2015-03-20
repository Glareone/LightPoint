using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LightPoint.Domain.Services;
using LightPoint.Service;
using LightPoint.ServiceLocator;
namespace LightPoint.ASPMVC
{


    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Register Existing Services
            ServiceLocator.ServiceLocator.RegisterService<IShopService>(typeof(ShopService));
            ServiceLocator.ServiceLocator.RegisterService<IGoodsService>(typeof(GoodsService));

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
