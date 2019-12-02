using Labaratornay_rabota2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6_part2
{
    public class Circle : geometr_figur
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
        public Circle(double radius)
        {
            this.radius = radius;
            this.Type = "Круг";
        }
        public override double ploshad()
        {
            return (Math.PI * radius * radius);
        }
        public Circle()
        {
            this.Type = "Круг";
        }
        public int example(int x, int y)
        {
            return (x + y);
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
