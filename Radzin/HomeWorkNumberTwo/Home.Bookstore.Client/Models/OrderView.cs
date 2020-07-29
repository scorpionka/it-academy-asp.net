using Home.Bookstore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Bookstore.Client.Models
{
    public class OrderView
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public DateTime Date { get; set; }
        public BookData bookdata { get; set; }
    }
}