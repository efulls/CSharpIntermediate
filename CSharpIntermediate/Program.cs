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
            //int number;
            //var result = int.TryParse("abc", out number);
            //if(result)
            //    Console.WriteLine(number);
            //else
            //    Console.WriteLine("Conversion failed.");
            #endregion

            #region Fields
            //var customer = new Customer(1);
            //customer.Orders.Add(new Order());
            //customer.Orders.Add(new Order());

            //customer.Promote();

            //Console.WriteLine(customer.Orders.Count);
            #endregion

            #region Access Modifiers

            //var person = new Person();
            //person.SetBirthDate(new DateTime(1992, 1, 1));
            //Console.WriteLine(person.GetBirthdate());
            #endregion

            #region Properties
            //var person = new Person(new DateTime(1992, 2, 2));
            //Console.WriteLine(person.Age);
            #endregion

            #region Indexers
            //var cookie = new HttpCookie();
            //cookie["name"] = "Efuull";
            //Console.WriteLine(cookie["name"]);
            #endregion

            #region Inheritance
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();
            #endregion

            #region Composition
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
            #endregion

        }

        #region Methods in Methods
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
        #endregion
    }
}
