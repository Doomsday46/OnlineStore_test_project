using AutoMapper;
using Ninject;
using OnlineStore.App_Data;
using OnlineStore.Mappers;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace OnlineStore.App_Start
{
    public static class NinjectWebCommon
    {

        public static void Start()
        {

        }

        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<AuthDBDataContext>().ToMethod(c => new AuthDBDataContext(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString));
            kernel.Bind<IRepository>().To<SqlRepository>();
            kernel.Bind<IMapper>().To<CommonMapper>().InSingletonScope();
        }
    }
}