using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Bookstore.Data.Models
{
    public class OrderData
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public BookData bookdata { get; set; }
    }
}
