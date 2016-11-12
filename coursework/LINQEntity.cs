using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;
using System.Windows.Forms;


namespace coursework
{
    class LINQEntity
    {
        private List<float> points = new List<float>();

        public LINQEntity(List<float> _points)
        {
            points = _points;
        }

        public float Minimum()
        {
            // Define the query expression.
            IEnumerable<float> pointsQuery = from point in points
                                            select point;
            return pointsQuery.Min();
        }

        public float Maximum()
        {
            IEnumerable<float> pointsQuery = from point in points
                                             select point;
            return pointsQuery.Max();
        }

        public float calculateSumOfEven()
        {
            IEnumerable<float> pointsQuery = from point in points
                                             where ((int)point % 2) == 0
                                             select point; 
            return pointsQuery.Sum();
        }

        public float multiplicationOfOdd()
        { 
            IEnumerable<float> pointsQuery = from point in points
                                             where ((int)point % 2) != 0
                                             select point;
            Func<float, float, float> lambda = (x, y) => x * y; 

            return pointsQuery.Aggregate(1, lambda);
        }

        public float Summa()
        {
            IEnumerable<float> pointsQuery = from point in points
                                             select point;
            return pointsQuery.Sum();
        }

        public float sumGreaterThanAverage()
        {
            IEnumerable<float> pointsQuery = from point in points
                                             where point > points.Average() 
                                             select point;
            return pointsQuery.Sum();
        }
    }
}
