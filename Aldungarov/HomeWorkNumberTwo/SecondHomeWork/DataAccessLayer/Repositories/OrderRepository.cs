using System;
using System.Collections.Generic;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Repositories;

namespace DataAccessLayer.Repositories
{
    public class OrderRepository : BaseRepository, IOrderRepository
    {
        public Order GetOrder()
        {
            Order someOrder = new Order();
            someOrder.id = 1;
            someOrder.orderDate = new DateTime(2020, 03, 02).ToString();
            someOrder.bookName = "Some Book Name";
            
            return someOrder;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();
            for (int i = 1; i <= 10; i++) 
            {
                Order someOrder = new Order();
                someOrder.id = i;
                if (i == 5 || i == 7)
                {
                    someOrder.orderDate = DateTime.Now.ToString();
                }
                else 
                {
                    someOrder.orderDate = new DateTime(2020, 03, 02).ToString();
                }
                someOrder.bookName = "Some Book Name" + i;
                orderList.Add(someOrder);
            }
            
            return orderList;
        }

        public List<Order> GetTodayOrders()
        {
            List<Order> orderList = new List<Order>();
            for (int i = 1; i <= 10; i++)
            {
                Order someOrder = new Order();
                someOrder.id = i;
                if (i == 5 || i == 7)
                {
                    someOrder.orderDate = DateTime.Now.ToString();
                }
                else
                {
                    someOrder.orderDate = new DateTime(2020, 03, 02).ToString();
                }
                someOrder.bookName = "Some Book Name" + i;
                orderList.Add(someOrder);
            }

            return orderList.FindAll(delegate (Order order)
                                     {
                                         return order.orderDate == DateTime.Now.ToString();
                                     });
        }
    }
}
