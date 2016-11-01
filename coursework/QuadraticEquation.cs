using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    class QuadraticEquation
    {
        public QuadraticEquation() { }

        //  class fields
        private double discriminant;
        private double coeff_a, coeff_b, coeff_c;

        public void setCoefficients(double a, double b, double c)
        {
            coeff_a = a;
            coeff_b = b;
            coeff_c = c;
        }


        public float solveByDiscriminant()
        {
            double z1, z2;

            discriminant = (coeff_b * coeff_b) - 4 * coeff_a * coeff_c;     //  regular discriminant expression 

            z1 = (-coeff_b + Math.Sqrt(discriminant)) / (2 * coeff_a);
            z2 = (-coeff_b - Math.Sqrt(discriminant)) / (2 * coeff_a);

            return (float)Math.Min( Math.Abs(z1), Math.Abs(z2) );
        }
    }
}
