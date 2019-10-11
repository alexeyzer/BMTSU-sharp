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
            circle cir = new circle();
            square sqr = new square();
            rectangle rct = new rectangle();

            cir.property_radius = 6;
            rct.property_shirina = 5;
            rct.property_visota = 6;
            sqr.property_visota = 4;
            sqr.property_shirina = 4;

            cir.Print();
            sqr.Print();
            rct.Print();

        }
    }
}