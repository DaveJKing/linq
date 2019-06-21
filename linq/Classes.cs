using System;
namespace linq
{

    //new Customer() { Identifier = 1, FirstName = "Hans", LastName = "Meier" },
    

    //new Order() { Identifier = 101, CustomerIdentifier = 2, TotalPrice = 750 },

   

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int TotalPrice { get; set; }
    }
}
