using AutoMapper;
using HomaWork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Data.Entities;

namespace HomeWork.Bll
{
    class Automapper
    {
        static Mapper mapper;
        public static Mapper GetMapper()
        {
            if (mapper == null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Book, BookModel>();
                    cfg.CreateMap<BookModel, Book>();

                    cfg.CreateMap<Order, OrderModel>();
                    cfg.CreateMap<OrderModel, Order>();
                });

                mapper = new Mapper(config);
            }

            return mapper;
        }
    }
}
