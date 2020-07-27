using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomaWork.BLL.Models
{
    public class OrderItemModel    {
        public int Id { get; set; }
        public BookModel Book { get; set; }
        public int Quantity { get; set; }

    }
}
