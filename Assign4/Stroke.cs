using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    public class Stroke
    {
        public Pen StrokePen { get; set; }
        public List<Point> Points = new List<Point>();

        public Stroke(Pen pen, List<Point> points)
        {
            StrokePen = pen;
            Points = points;
        }
    }
}
