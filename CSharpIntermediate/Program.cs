using CSharpIntermediate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpIntermediate.Demo.ClassesDemo;

namespace CSharpIntermediate
{
    
    class Program
    {
        static void Main(string[] args)
        {
            /* Demo Introduction Classes */
            //var person = Person.Parse("John");
            //person.Introduce("Eful");

            /* Demo Constructors*/
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
