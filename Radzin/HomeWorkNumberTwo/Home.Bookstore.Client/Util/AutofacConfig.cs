using Autofac;
using Autofac.Integration.Mvc;
using Home.Bookstore.Data.Repositories;
using Home.Bookstore.Data.Repositories.Interfaces;
using Home.Bookstore.Domain.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Home.Bookstore.Client.Util
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
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}