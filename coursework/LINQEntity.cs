﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;


namespace coursework
{
    class LINQEntity
    {
        private List<float> points = new List<float>();

        public LINQEntity(List<float> _points)
        {
            points = _points;
        }


    }
}
