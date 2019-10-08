using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    public abstract class geometr_figur
    {
        abstract public double ploshad();
        public string Type { get; protected set; }

        public override string ToString() { return this.Type + " площадью " + this.ploshad().ToString(); }
    }
}
