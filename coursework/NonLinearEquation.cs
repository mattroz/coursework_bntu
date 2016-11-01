using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    GIVEN EQUATION: X - 1/(9 + SIN(3.6X)) = 0
 */

namespace coursework
{
    /// <summary>
    /// Class for non-linear equations solving
    /// </summary>
    class NonLinearEquation
    {

        //  class fields
        private double left_interval;
        private double right_interval;
        private double epsilon;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="left">Left root interval</param>
        /// <param name="right">Right root interval</param>
        /// <param name="eps">Approximation</param>
        public NonLinearEquation(double left, double right, double eps)
        {
            this.left_interval = left;
            this.right_interval = right;
            this.epsilon = eps;
        }

        /// <summary>
        /// Calculates approximate root of given one-variable equation
        /// </summary>
        /// <returns></returns>
        public double solveByIterationsMethod()
        { 
            double x_current, x_previous;
            int i = 0;

            //  calculate
            x_current = (this.right_interval - this.left_interval) / 2;
    
            do
            {
                x_previous = x_current;
                x_current = (1 / (9 + Math.Sin(3.6 * x_previous)));
            } while(Math.Abs(x_current - x_previous) > this.epsilon);

            return x_current;
        }
    }
}
