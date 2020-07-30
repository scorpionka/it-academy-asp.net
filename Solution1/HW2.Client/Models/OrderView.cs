using HW2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW2.Client.Models
{
    public class OrderView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BooksOrder { get; set; }
        public DateTime DayTime { get; set; }
    }
}