using Home.Bookstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Bookstore.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public BookData bookdata { get; set; }
    }
}
