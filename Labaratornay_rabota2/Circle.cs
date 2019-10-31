using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    public class circle : geometr_figur, IPrint
    {
        private double radius;
        public double property_radius 
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public circle(double radius)
        {
            this.radius = radius;
            this.Type = "Круг";
        }
        public override double ploshad()
        {
            return (Math.PI * radius * radius);
        }
        public circle()
        {
            this.Type = "Круг";
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
