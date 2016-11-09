using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class PolynomialEquation
    {
        public PolynomialEquation(){ }

        /*   CLASS FIELDS   */
        private double coeff_a, coeff_b, coeff_c, coeff_d;

        public double aCoefficient 
        {
            set { coeff_a = value; }
            get { return coeff_a; }
        }

        public double bCoefficient
        {
            set { coeff_b = value; }
            get { return coeff_b; }
        }

        public double cCoefficient
        {
            set { coeff_c = value; }
            get { return coeff_c; }
        }

        public double dCoefficient
        {
            set { coeff_d = value; }
            get { return coeff_d; }
        }

        public float calculateCurrentValue(float time)
        { 
            return (float)((coeff_a * (time*time*time)) + 
                           (coeff_b * (time*time)) + (coeff_c * time) - (coeff_d));
        }
    }
}
