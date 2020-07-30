using Autofac;
using Autofac.Integration.Mvc;
using HW2.Data.Repositories;
using HW2.Domain.DomainServices;
using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Repositories;
using System.Web.Mvc;

namespace HW2.Client.Util
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
            builder.RegisterType<BookDomainService>().As<IBookDomainService>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}