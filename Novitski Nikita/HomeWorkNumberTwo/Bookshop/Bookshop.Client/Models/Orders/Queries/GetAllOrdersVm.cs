using Bookshop.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookshop.Client.Models.Orders.Queries
{
    public class GetAllOrdersVm
    {
       public List<Order> Orders { get; set; }
    }
}