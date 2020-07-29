using Autofac;
using Autofac.Integration.Mvc;
using Bookshop.Data.Context;
using Bookshop.Data.Repositories;
using Bookshop.Domain.DomainServices.OrderDomainService;
using Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces;
using Bookshop.Domain.DomainServices.ProductDomainService;
using Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces;
using Bookshop.Domain.Repositories;
using System.Reflection;
using System.Web.Mvc;

namespace Bookshop.Client.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            // регистрируем споставление типов
            builder.RegisterType<GetAllOrdersDomainService>().As<IGetAllOrdersDomainService>();
            builder.RegisterType<GetOrdersMadeTodayDomainService>().As<IGetOrdersMadeTodayDomainService>();

            builder.RegisterType<GetAllBooksDomainService>().As<IGetAllBooksDomainService>();
            builder.RegisterType<GetTopFiveBooksDomainService>().As<IGetTopFiveBooksDomainService>();

            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<VirtualDb>().As<IVirtualDb>();


            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}