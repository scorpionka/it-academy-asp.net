using Autofac;
using Autofac.Integration.Mvc;
using BusinessLogicLayer.DomainServices;
using BusinessLogicLayer.Repositories;
using DataAccessLayer.Repositories;
using System.Web.Mvc;

namespace SecondHomeWork.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // регистрируем споставление типов
            builder.RegisterType<OrderDomainService>().As<IOrderDomainService>();
            builder.RegisterType<BookDomainService>().As<IBookDomainService>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}