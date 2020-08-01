using System;
using System.Collections.Generic;

namespace HW2.Domain.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> BooksOrder { get; set; }
        public DateTime DayTime { get; set; }
    }
}
