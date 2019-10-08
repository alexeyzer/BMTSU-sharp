using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    class Program
    {
        static void Main(string[] args)
        {
            circle cir = new circle(6);
            square sqr = new square(6);
            rectangle rct = new rectangle(6,4);
            
            cir.Print();
            sqr.Print();
            rct.Print();

        }
    }
}