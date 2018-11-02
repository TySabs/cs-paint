using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assign4
{
    public partial class PaintApp : Form
    {
        public Stack leftStack = new Stack();
        public Stack rightStack = new Stack();
        public Graphics g;
        public Point point1;
        public Point point2;
        public Color selectedColor = Color.Black;

        public List<Tuple<Pen, Point, Point>> lines = new List<Tuple<Pen, Point, Point>>();
    }
}
