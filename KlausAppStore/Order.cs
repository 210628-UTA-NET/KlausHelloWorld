using System;
using System.Collections.Generic;

namespace klausAppStore
{
    public class Order
    {
        public Order()
        {}
        public string name {get;set;}
        public string address {get;set;}
        public string email {get;set;}
        public List<Order> listOfOrders  {get;set;}
    }
}
