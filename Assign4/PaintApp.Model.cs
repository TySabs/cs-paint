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
        private Stack leftStack = new Stack();
        private Stack rightStack = new Stack();
        private Graphics g;
        private Point point1;
        private Point point2;
        private Color selectedColor = Color.Black;

        public List<Tuple<Pen, Point, Point>> lines = new List<Tuple<Pen, Point, Point>>();
        public List<Point> points = new List<Point>();

        private bool isLineSelected = false;
        private bool isPencilSelected = false;
        private bool isPaintSelected = false;
        private bool isEraserSelected = false;
    }
}
