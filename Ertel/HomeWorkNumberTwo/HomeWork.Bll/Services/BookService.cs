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
    class BookService : IBookService
    {
        private readonly IUnitOfWork database;

        public BookService(IUnitOfWork uow)
        {
            this.database = uow;
        }

        public IEnumerable<BookModel> GetAll()
        {
            var Books = database.Books.GetAll().ToList();
            var mapper = Automapper.GetMapper();
            var companiesModel = Books.Select(x => mapper.Map(x, typeof(Book), typeof(BookModel)) as BookModel).ToList();
            return companiesModel;
        }

        public IEnumerable<BookModel> GetTopFive()
        {
            var Books = database.Books.TopFive().ToList();
            var mapper = Automapper.GetMapper();
            var companiesModel = Books.Select(x => mapper.Map(x, typeof(Book), typeof(BookModel)) as BookModel).ToList();
            return companiesModel;
        }
    }
}
