using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign4
{
    public class Line : PaintAction
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Line(Pen pen, Point start, Point end) : base()
        {
            PaintPen = pen;
            StartPoint = start;
            EndPoint = end;
        }
    }
}
