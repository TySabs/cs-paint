using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    public class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Pen LinePen { get; set; }

        public Line(Pen pen, Point start, Point end)
        {
            LinePen = pen;
            StartPoint = start;
            EndPoint = end;
        }
    }
}
