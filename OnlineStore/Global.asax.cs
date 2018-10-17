using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using OnlineStore.Models;
using System.Data.Entity;
using Ninject;
using OnlineStore.App_Data;
using System.Configuration;

namespace OnlineStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        [Inject]
        public IRepository Repository { get; set; }

        protected void Application_Start()
        {
            Database.SetInitializer(new DBInitialazer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<AuthDBDataContext>().ToMethod(c => new AuthDBDataContext(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString));
            kernel.Bind<IRepository>().To<SqlRepository>();
        }
    }
}
