using System;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

           

            List<Customer> _customers = new List<Customer>()
        {

             new Customer() { Id = 1, FirstName = "Hans", LastName = "Meier" },

             new Customer() { Id = 2, FirstName = "Uwe", LastName = "Mueller" },

             new Customer() { Id = 3, FirstName = "Sandra", LastName = "Schmidt" }

        };

            Console.WriteLine("Id FirstName  LastName");
            foreach (var c in _customers)
            {

                Console.WriteLine("{0} {1} {2}", c.Id, c.FirstName, c.LastName);
            }

            List<Order> _orders = new List<Order>()

            {

            new Order() { Id = 101, CustomerId = 2, TotalPrice = 750 },

            new Order() { Id = 102, CustomerId = 2, TotalPrice = 80 },

            new Order() { Id = 103, CustomerId = 2, TotalPrice = 120 },

            new Order() { Id = 104, CustomerId = 3, TotalPrice = 55 }

        };


            Console.WriteLine("Id CustId  TotalPrice");
            foreach (var o in _orders)
            {

                Console.WriteLine("{0} {1} {2}", o.Id, o.CustomerId, o.TotalPrice);
            }



        }
    }
}



//public class Customer
//{
//    public int Identifier { get; set; }
//    public string Firstname { get; set; }
//    public string Lastname { get; set; }
//}


