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
    }
}
