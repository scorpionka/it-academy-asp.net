using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomaWork.BLL.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<BookModel> Books { get; set; }

        public OrderModel()
        {
            Books = new List<BookModel>();
        }
}
}
