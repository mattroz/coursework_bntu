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
        private float left_interval;
        private float right_interval;
        private float epsilon;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="left">Left root interval</param>
        /// <param name="right">Right root interval</param>
        /// <param name="eps">Approximation</param>
        NonLinearEquation(float left, float right, float eps)
        {
            this.left_interval = left;
            this.right_interval = right;
            this.epsilon = eps;
        }

        /// <summary>
        /// Calculates approximate root of given one-variable equation
        /// </summary>
        /// <returns></returns>
        public float solveByIterationsMethod()
        { 
            float []x = new float[3];
            int i = 0;

            //  calculate
            x[0] = (this.right_interval - this.left_interval) / 2;
    
            do
            {
                
            } while(Math.Abs(x[i] - x[i - 1]) > this.epsilon);
        }
    }
}
