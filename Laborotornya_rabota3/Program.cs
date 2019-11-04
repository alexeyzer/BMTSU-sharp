using System;
using System.Collections.Generic;
using System.Collections;
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


            ArrayList l1 = new ArrayList();
            l1.Add(circle);
            l1.Add(rect);
            l1.Add(square);
            Console.WriteLine("ArrayList:");
            foreach (object i in l1) Console.Write(i.ToString() + " ");

            Console.Write("\nList:");
            List<geometr_figur> l2 = new List<geometr_figur>(); 
            l2.Add(circle); 
            l2.Add(rect); 
            l2.Add(square);
            Console.WriteLine("\nПеред сортировкой:"); 
            foreach (object i in l2) Console.Write(i.ToString() + " ");
            l2.Sort();
            Console.WriteLine("\nПосле сортировки:"); 
            foreach (object i in l2) Console.Write(i.ToString() + " ");
            Console.WriteLine("");

            Console.WriteLine("Стек");
            SimpleStack<geometr_figur> stack = new SimpleStack<geometr_figur>(); 
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0) 
            { 
                geometr_figur f = stack.Pop(); 
                Console.WriteLine(f); }
        }
    }
}
