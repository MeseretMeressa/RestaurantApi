using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication1.Controllers
{
    public class OrderController : ApiController
    {
        // GET api/order
        public IEnumerable<Order> Get()
        {
            Order sample = new Order();
            OrderItem item = new OrderItem();
            item.item = "Girgiro";
            item.itemQuantity =2;
            item.message = "Not so hot";

            sample.tableNumber = 1345;
            sample.orderId = "12345";
            sample.orderItems = new OrderItem[] { item };
            //You fetch data from the DB
            //display the result
            return new Order[] { sample,new Order(), new Order() ,new Order()};
        }

        // GET api/order/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/order
        public void Post([FromBody]string value)
        {
        }

        // PUT api/order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/order/5
        public void Delete(int id)
        {
        }
    }
}
