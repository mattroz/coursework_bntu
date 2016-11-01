using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
