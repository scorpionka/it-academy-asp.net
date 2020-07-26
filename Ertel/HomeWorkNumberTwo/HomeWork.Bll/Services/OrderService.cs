using HomaWork.BLL.Models;
using HomeWork.Bll.Interfaces;
using HomeWork.Data.Entities;
using HomeWork.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Bll.Services
{
    public class OrderService: IOrderService
    {
        private readonly IUnitOfWork database;

        public OrderService(IUnitOfWork uow)
        {
            this.database = uow;
        }

        public IEnumerable<OrderModel> GetAll()
        {
            var Books = database.Orders.GetAll().ToList();
            var mapper = Automapper.GetMapper();
            var companiesModel = Books.Select(x => mapper.Map(x, typeof(Order), typeof(OrderModel)) as OrderModel).ToList();
            return companiesModel;
        }

        public IEnumerable<OrderModel> TodayOrders()
        {
            var Books = database.Orders.TodayOrders().ToList();
            var mapper = Automapper.GetMapper();
            var companiesModel = Books.Select(x => mapper.Map(x, typeof(Order), typeof(OrderModel)) as OrderModel).ToList();
            return companiesModel;
        }
    }
}
