
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting
            /* Bagian 1
             --------------*/

            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);

            /* Bagian 2
             --------------*/

            //StreamReader reader = new StreamReader(new MemoryStream());

            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Efulls");
            //list.Add(new Text());

            //var anotherList = new List<Shape>();

            #endregion

            #region DownCasting
            /* Lakukan konversi sebelum menggunakan text seperti contoh dibawa dikonversi menajadi Text terlebih dahulu*/
            Shape shape = new Text();
            Text text = (Text) shape;
            
            #endregion

        }
    }
}
