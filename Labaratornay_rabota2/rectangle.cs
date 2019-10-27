using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    public class rectangle : geometr_figur, IPrint
    {
        private double shirina;
        private double visota;

        public double property_visota 
        {
            get
            {
                return visota;
            }
            set 
            {
                visota = value;
            } 
        }
        public double property_shirina
        {
            get 
            {
                return shirina;
            }
            set
            {
                shirina = value;
            }
        }

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
        public rectangle()
        {
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            return ploshad();
        }

    }
}
