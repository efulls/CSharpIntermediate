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
            #region Introduction Classes
            /* Demo Introduction Classes */
            //var person = Person.Parse("John");
            //person.Introduce("Eful");
            #endregion

            #region Constructors
            /* Demo Constructors*/
            //var customer = new Customer();
            //customer.Id = 1;
            //customer.Name = "John";

            //var order = new Order();
            //customer.Orders.Add(order);


            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);
            #endregion

            #region Methods
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
            #endregion


        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}.{1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}.{1})", point.X, point.Y);

            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured.");
            }

        }
    }
}
