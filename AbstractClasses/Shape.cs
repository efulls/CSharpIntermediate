using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int With { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clopboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape.");
        }
    }
}
