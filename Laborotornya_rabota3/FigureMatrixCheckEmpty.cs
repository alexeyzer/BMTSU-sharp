using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labaratornay_rabota2;

namespace Laborotornya_rabota3
{
    class FigureMatrixCheckEmpty : IMatrixCheckEmpty<geometr_figur>
    {
        public geometr_figur getEmptyElement()
        {
            return null;
        }
        public bool checkEmptyElement(geometr_figur element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}
