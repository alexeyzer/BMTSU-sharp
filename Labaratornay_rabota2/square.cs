using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornay_rabota2
{
    public class square : rectangle
    {
        public square(double storona) : base(storona, storona)
        {
            this.Type = "Квадрат";
        }

    }
}
