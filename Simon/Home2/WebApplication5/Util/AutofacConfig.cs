using Autofac;
using Autofac.Integration.Mvc;
using DomainLogics.DomainServices;
using DomainLogics.DomainServices.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
                builder.RegisterControllers(typeof(MvcApplication).Assembly);
                builder.RegisterType<BookDomainService>().As<IBookDomainService>();
                builder.RegisterType<OrderDomainService>().As<IOrderDomainService>();
            var container = builder.Build();

                DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}