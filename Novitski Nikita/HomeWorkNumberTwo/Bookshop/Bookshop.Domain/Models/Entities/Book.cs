using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Domain.Models.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }

        public List<Order> Orders { get; set; }




    }
}
