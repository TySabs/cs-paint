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
        private static Pen selectedPen = new Pen(Color.Black);

        public List<Line> lines = new List<Line>();
        public List<Stroke> strokes = new List<Stroke>();
        public Stroke brushStroke = new Stroke(selectedPen, new List<Point>());

        private bool isLineSelected = false;
        private bool isPencilSelected = false;
        private bool isPaintSelected = false;
        private bool isEraserSelected = false;
        private bool isCustom = false; 

        private bool isMouseDown = false;
    }
}
