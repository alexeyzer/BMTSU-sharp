using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labaratornay_rabota2; 

namespace Laborotornya_rabota3
{
    class Program
    {
        static void Main()
        {
            rectangle rect = new rectangle(5, 4); 
            square square = new square(5);
            circle circle = new circle(5);
            List<geometr_figur> fl = new List<geometr_figur>(); fl.Add(circle); fl.Add(rect); fl.Add(square);
            Console.WriteLine("\nПеред сортировкой:"); 
            foreach (object i in fl) Console.Write(i.ToString() + " ");
            fl.Sort();
            Console.WriteLine("\nПосле сортировки:"); 
            foreach (object i in fl) Console.Write(i.ToString() + " ");
        }
    }
}
