using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Data.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }

    }
}
