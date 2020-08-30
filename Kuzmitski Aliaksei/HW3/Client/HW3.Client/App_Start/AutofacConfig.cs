using Autofac;
using Autofac.Integration.Mvc;
using HW3.Data.Repositories;
using HW3.Domain.DomainServices;
using HW3.Domain.DomainServices.Interfaces;
using HW3.Domain.Repositories;
using System.Web.Mvc;

namespace HW3.Client.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<UserDomainService>().As<IUserDomainService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}