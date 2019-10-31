using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    public abstract class geometr_figur : IComparable
    {
        abstract public double ploshad();
        public string Type { get; protected set; }

        public override string ToString() { return this.Type + " площадью " + this.ploshad().ToString(); }


        public int CompareTo(object obj)
        { 
            geometr_figur p = (geometr_figur)obj;
            if (this.ploshad() < p.ploshad()) 
                return -1;
            else if (this.ploshad() == p.ploshad())
                return 0;
            else return 1;
        }
    }
}
