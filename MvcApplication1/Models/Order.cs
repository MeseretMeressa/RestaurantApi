using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Order
    {
        public string orderId{get;set;}
        public int tableNumber{get;set;}
        public OrderItem[] orderItems { get; set; }

    }
}