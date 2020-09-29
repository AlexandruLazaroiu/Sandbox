using System;
using System.Data.SqlTypes;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using Sandbox;

namespace Pizza1to1
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Customer customer1 = new Customer();
            customer1.Name = "John Doe";
            customer1.Address = "Flowers str.1";
            customer1.Phone = "01xxxxxxx";
            customer1.Email = "johndoex1@gmail.com";

            Customer customer2 = new Customer();
            customer2.Name = "Joe Smith";
            customer2.Address = "Union str. 223";
            customer2.Phone = "02xxxxxxx";
            customer2.Email = "joesmith66@yahoo.com";

            Pizza pizza1=new Pizza();
            pizza1.PizzaNo = 1;
            pizza1.Price = 50;
            pizza1.size = "small";

            Pizza pizza2=new Pizza();
            pizza2.PizzaNo = 2;
            pizza2.Price = 100;
            pizza2.size = "large";

            Order Order1 = new Order(01, DateTime.Now);
            Order1.Customer = customer1;
            Order1.Pizza = pizza1;

            Order Order2 = new Order(02,DateTime.Now);
            Order2.Customer = customer2;
            Order2.Pizza = pizza2;

            Console.WriteLine($"The order {Order1.OrderID} is for {Order1.Customer.Name} and contains pizza no. {Order1.Pizza.PizzaNo},costing {Order1.Pizza.Price}.");
            Console.WriteLine($"The order {Order2.OrderID} is for {Order2.Customer.Name} and contains pizza no. {Order2.Pizza.PizzaNo},costing {Order2.Pizza.Price}.");



            // The LAST line of code should be ABOVE this line
        }
    }
}