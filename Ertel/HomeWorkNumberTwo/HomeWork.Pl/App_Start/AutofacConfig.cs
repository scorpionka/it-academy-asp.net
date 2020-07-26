using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Autofac.Integration.Mvc;
using HomeWork.Bll;

namespace HomeWork.Pl.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer(string connectionString)
        {
            var builder = AutofacBuilder.GetBuilder(connectionString);
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(builder.Build()));
        }
    }
}