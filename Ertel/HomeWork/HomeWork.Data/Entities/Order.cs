using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Book> Books { get; set; }

        public Order()
        {
            Books = new List<Book>();
        }
}
}
