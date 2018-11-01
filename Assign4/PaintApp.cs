using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public PaintApp()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox; 

  //          pictureBox1.BackColor = temp.BackColor;
            selectedColor = temp.BackColor; 

        }

        private void PaintCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (point1.IsEmpty)
            {
                point1 = e.Location;
            } else if (point2.IsEmpty)
            {
                point2 = e.Location;
            }
        }

        private void PaintCanvas_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void PaintCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!point1.IsEmpty && !point2.IsEmpty)
            {
                PaintCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCanvas_Paint);
                PaintCanvas.Refresh();
            }
        }

        private void PaintCanvas_Paint(object sender, PaintEventArgs e)
        {

            Pen linePen = new Pen(selectedColor);

            if (!point1.IsEmpty && !point2.IsEmpty)
            {

                int x1 = point1.X;
                int y1 = point1.Y;
                int x2 = point2.X;
                int y2 = point2.Y;

                e.Graphics.DrawLine(linePen, x1, y1, x2, y2);

                point1 = Point.Empty;
                point2 = Point.Empty;


            }

    
        }
    }
}
