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
            infoCanvas.BackColor = temp.BackColor;

            selectedPen = new Pen(selectedColor);
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

            if (isPencilSelected)
            {
                brushStroke = new Stroke(selectedPen, new List<Point>());
                brushStroke.Points.Add(e.Location);
            }

            if (isEraserSelected)
            {
                Pen eraserPen = new Pen(PaintCanvas.BackColor, 10);
                brushStroke = new Stroke(eraserPen, new List<Point>());
                brushStroke.Points.Add(e.Location);
            }

            if (isPaintSelected)
            {
                Pen paintPen = new Pen(selectedColor, 10);
                brushStroke = new Stroke(paintPen, new List<Point>());
                brushStroke.Points.Add(e.Location);
            }
        }

        private void PaintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (isPencilSelected || isEraserSelected || isPaintSelected || isCustom))

            {
                brushStroke.Points.Add(e.Location);

                PaintCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCanvas_Paint);
                PaintCanvas.Refresh();
            }
        }

        private void PaintCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isLineSelected && !point1.IsEmpty && !point2.IsEmpty)
            {
                Line newLine = new Line(selectedPen, point1, point2);
                lines.Add(newLine);

                PaintCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCanvas_Paint);
                PaintCanvas.Refresh();

                point1 = Point.Empty;
                point2 = Point.Empty;
            }

            if (isPencilSelected || isEraserSelected || isPaintSelected || isCustom)
            {
                strokes.Add(brushStroke);

                PaintCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCanvas_Paint);
                PaintCanvas.Refresh();
            }
        }

        private void PaintCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (lines.Count > 0)
            {
                foreach (Line line in lines)
                {
                    int x1 = line.StartPoint.X;
                    int y1 = line.StartPoint.Y;
                    int x2 = line.EndPoint.X;
                    int y2 = line.EndPoint.Y;

                    e.Graphics.DrawLine(line.LinePen, x1, y1, x2, y2);
                }
            }

            if (brushStroke.Points.Count > 0)
            {
                foreach (Stroke stroke in strokes)
                {
                    e.Graphics.DrawLines(stroke.StrokePen, stroke.Points.ToArray());
                }

                e.Graphics.DrawLines(brushStroke.StrokePen, brushStroke.Points.ToArray());
            }
        } 

        private void LineButton_Click(object sender, EventArgs e)
        {
            isPencilSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;
            isCustom = false; 
            isLineSelected = true;

            textBox1.Text = "Draw Line";
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;
            isCustom = false;
            isPencilSelected = true;
            textBox1.Text = "Pencil"; 
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPencilSelected = false;
            isEraserSelected = false;
            isCustom = false;
            isPaintSelected = true;

            textBox1.Text = "Brush";
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPencilSelected = false;
            isPaintSelected = false;
            isCustom = false;
            isEraserSelected = true;

            textBox1.Text = "Eraser";
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Undo";
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Redo";
        }

        private void SizeButton_Click(object sender, EventArgs e)
        {
          //  Pen eraserPen = new Pen(selectedColor, (float)upDown.Value);
            textBox1.Text = "Custom";
            isPencilSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;
            isCustom = true;
            isLineSelected = false;
        }

    }
}