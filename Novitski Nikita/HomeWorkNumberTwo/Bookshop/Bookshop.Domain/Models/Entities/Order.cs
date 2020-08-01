using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Domain.Models.Entities
{
    public class Order :BaseEntity
    {
        public string CustomerName { get; set; }

        public DateTime CreatedAt { get; set; }

        public List<Book> Books { get; set; }
         
    }
}
