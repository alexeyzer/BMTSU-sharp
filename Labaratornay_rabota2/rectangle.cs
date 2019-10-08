using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    public class rectangle : geometr_figur, IPrint
    {
        public double visota { get; set; }
        public double shirina { get; set; }

        public override double ploshad()
        {
            return (this.visota * this.shirina);
        }
        public rectangle(double visota, double shirina)
        {
            this.visota = visota;
            this.shirina = shirina;
            this.Type = "Прямоугольник";
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
