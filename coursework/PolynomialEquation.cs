using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    class PolynomialEquation
    {
        public PolynomialEquation(){ }

        /*   CLASS FIELDS   */
        private double []coefficient;
        private int coefficients_number;

        public void setCoefficients(TextBox []_coefficientsAtTextBoxes, int _num)
        {
            coefficients_number = _num;
            coefficient = new double[coefficients_number];
            
            /*   set coefficients in big-endian order   */
            for (int i = 0; i < coefficients_number; i++)
            {
                coefficient[i] = Convert.ToDouble(_coefficientsAtTextBoxes[i].Text);
            }
        }

        public float currentValueByHorner(float time)
        { 
            double sum = 0;
            for (int i = 0; i < coefficients_number - 1; i++)
            {
                sum += coefficient[i];
                sum *= time;   
            }
            
            /*   the last coefficient aint multiplied by time, so just add it to the result   */
            return (float)(sum + coefficient[coefficient.Length - 1]);
        }
    }
}
