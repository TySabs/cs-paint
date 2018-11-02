using System;
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
        private void Box_Click(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            selectedColor = temp.BackColor;
        }

        private void PaintCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (isLineSelected)
            {
                if (point1.IsEmpty)
                {
                    point1 = e.Location;
                }
                else if (point2.IsEmpty)
                {
                    point2 = e.Location;
                }
            }
        }

        private void PaintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void PaintCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isLineSelected && !point1.IsEmpty && !point2.IsEmpty)
            {
                Pen linePen = new Pen(selectedColor);

                Tuple<Pen, Point, Point> newLine = new Tuple<Pen, Point, Point>(linePen, point1, point2);
                lines.Add(newLine);

                PaintCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCanvas_Paint);
                PaintCanvas.Refresh();

                point1 = Point.Empty;
                point2 = Point.Empty;
            }

        }

        private void PaintCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (isLineSelected && !point1.IsEmpty && !point2.IsEmpty)
            {
                foreach (Tuple<Pen, Point, Point> line in lines)
                {
                    int x1 = line.Item2.X;
                    int y1 = line.Item2.Y;
                    int x2 = line.Item3.X;
                    int y2 = line.Item3.Y;

                    e.Graphics.DrawLine(line.Item1, x1, y1, x2, y2);
                }
            }
        } 

        private void LineButton_Click(object sender, EventArgs e)
        {
            isPencilSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;

            isLineSelected = true;
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;

            isPencilSelected = true;
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPencilSelected = false;
            isEraserSelected = false;

            isPaintSelected = true;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPencilSelected = false;
            isPaintSelected = false;

            isEraserSelected = true;
        }
    }
}
