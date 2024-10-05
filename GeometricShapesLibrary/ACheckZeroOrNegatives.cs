using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesLibrary
{
    public abstract class ACheckZeroOrNegatives
    {
        public virtual bool CheckZeroOrNegativesParameterValues(double[] sides)
        {
            foreach (double side in sides)
            {
                if (side <= 0)
                    return false;
            }
            return true;
        }
    }
}
