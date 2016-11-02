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
        private double left_bp;
        private double right_bp;
        private double epsilon;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="left">Left root interval</param>
        /// <param name="right">Right root interval</param>
        /// <param name="eps">Approximation</param>
        public NonLinearEquation(double left, double right, double eps)
        {
            leftBoundaryPoint = left;
            rightBoundaryPoint = right;
            epsilon = eps;
        }

        public NonLinearEquation()
        { 
            //  empty constructor
        }

        public double leftBoundaryPoint
        {
            get { return left_bp; }
            set { left_bp = value; }
        }

        public double rightBoundaryPoint
        {
            get { return this.right_bp; }
            set { this.right_bp = value; }
        }

        public double Epsilon
        {
            get { return this.epsilon; }
            set { this.epsilon = value; }
        }

        /// <summary>
        /// Calculates approximate root of given one-variable equation
        /// </summary>
        /// <returns></returns>
        public float solveByIterationsMethod()
        { 
            double x_current, x_previous;

            //  calculate the first one based on given intervals ([0, 0.85] in current case)
            x_current = (this.right_bp - this.left_bp) / 2;
    
            do
            {
                x_previous = x_current;
                x_current = (1 / (9 + Math.Sin(3.6 * x_previous)));
            } while(Math.Abs(x_current - x_previous) > epsilon);

            return (float)x_current;
        }

    }
}
