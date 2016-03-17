using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class OrderItem
    {
        public string item {get;set;}
        public int itemQuantity { get; set; }
        public string message { get; set; }
    }
}