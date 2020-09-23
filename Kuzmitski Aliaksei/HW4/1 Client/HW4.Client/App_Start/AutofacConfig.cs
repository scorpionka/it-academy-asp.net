using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;

namespace HW4.Client.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();


            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}