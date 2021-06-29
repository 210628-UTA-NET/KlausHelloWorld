using System;
using System.Collections.Generic;

namespace TrainingExercise0
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int NumberofCustomer;
            Customer NewCustomer =new Customer();
            //CustomerList MyCustList;
            List<Customer> MyCustomerList = new List<Customer>();
            Console.WriteLine("How many customers do we have");
            NumberofCustomer = Convert.ToInt32(Console.ReadLine());

            for(int i= 0; i<NumberofCustomer; i++)
            {
                Console.WriteLine("Customer number "+ i+1);
                Console.WriteLine("type the Name : ");
                NewCustomer.name = Console.ReadLine();

                Console.WriteLine("type the Email : ");
                NewCustomer.email = Console.ReadLine();

                Console.WriteLine("type the Address : ");
                NewCustomer.address = Console.ReadLine();

                //MyCustList.MyCustomerList.Add(NewCustomer);
                MyCustomerList.Add(NewCustomer);
                i++;
            }
            foreach(Customer cust in MyCustomerList ){
                Console.WriteLine(cust.name + "'s email is: "+cust.email+" and is located in "+cust.address);
            }
        }
    }
}
