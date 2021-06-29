using System;
using System.Collections.Generic;

namespace KASModels
{
    public class Customer
    {
        public Customer()
        {}
        public string name {get;set;}
        public string address {get;set;}
        public string email {get;set;}
        public List<Order> listOfOrders  {get;set;}
    }
}
