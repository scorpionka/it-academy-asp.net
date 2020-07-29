using HW2.Domain.DomainServices.Interfaces;
using HW2.Domain.Models;
using HW2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Domain.DomainServices
{
    public class BookDomainService : IBookDomainService
    {
        private readonly IBookRepository bookRepository;

        public BookDomainService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book AllOrders()
        {
            Book bookData = bookRepository.AllOrders();

            return bookData;
        }
    }
}
