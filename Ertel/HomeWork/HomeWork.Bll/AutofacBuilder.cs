using Autofac;
using HomeWork.Bll.Interfaces;
using HomeWork.Bll.Services;
using HomeWork.Data;
using HomeWork.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Bll
{
    public class AutofacBuilder
    {
        public static ContainerBuilder GetBuilder(string connectionString)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookService>().As<IBookService>();
            builder.RegisterType<OrderService>().As<IOrderService>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().WithParameter("connectionString", connectionString);
            return builder;
        }
    }
}
