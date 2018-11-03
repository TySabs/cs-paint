/************************************************************
 *                                                          *
 *  CSCI 473/504           Assignment 4         Fall 2018   *                                             
 *                                                          *
 *  Programmers: Tyler Saballus/Josh Ruge                   *
 *                                                          *
 *  Date Due:   Nov-1                                       *                          
 *                                                          *
 *  Purpose:    Clone of paint program, has pencil line     *
 *              draw, brush and eraser as well as undo and  *
 *              redo tools as well as a file system         *
 ***********************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Assign4
{
    public partial class PaintApp : Form
    {
        /*******************************************************
        * Color Choice Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: changes selcted color to the background
        * color of the textbox
        ******************************************************/
        private void Box_Click(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox;
            selectedColor = temp.BackColor;
            infoCanvas.BackColor = temp.BackColor;
            int penSize = 1;


            if (isLineSelected || isPencilSelected)
            { 
                if (isSmallSelected) penSize = 1;
                if (isMediumSelected) penSize = 2;
                if (isLargeSelected) penSize = 3;

                selectedPen = new Pen(selectedColor, penSize);
            }

            if (isPaintSelected)
            {
                if (isSmallSelected) penSize = 10;
                if (isMediumSelected) penSize = 20;
                if (isLargeSelected) penSize = 30;

                selectedPen = new Pen(selectedColor, penSize);
            }
        }

        /*******************************************************
        * Mouse Down Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void PaintCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (isLineSelected)
            {
                Bitmap eraserImage = Properties.Resources.line;
                Cursor = new Cursor(eraserImage.GetHicon());

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
                Bitmap pencilImage = Properties.Resources.pencil;
                Cursor = new Cursor(pencilImage.GetHicon());

                currentStroke = new Stroke(selectedPen, new List<Point>());
                currentStroke.Points.Add(new Point(e.Location.X - 10, e.Location.Y + 10));
            }

            if (isEraserSelected)
            {
                Bitmap eraserImage = Properties.Resources.eraser;
                Cursor = new Cursor(eraserImage.GetHicon());
                currentStroke = new Stroke(selectedPen, new List<Point>());
                currentStroke.Points.Add(e.Location);
            }

            if (isPaintSelected)
            {
                Bitmap paintImage = Properties.Resources.brush;
                Cursor = new Cursor(paintImage.GetHicon());
                currentStroke = new Stroke(selectedPen, new List<Point>());
                currentStroke.Points.Add(e.Location);
            }
        }

        /*******************************************************
        * Mouse Move Event
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void PaintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && (isPencilSelected || isEraserSelected || isPaintSelected))

            {
                currentStroke.Points.Add(new Point(e.Location.X - 10, e.Location.Y + 10));

                PaintCanvas.Refresh();
            }
        }

        /*******************************************************
        * Mouse Up Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void PaintCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (isLineSelected && !point1.IsEmpty && !point2.IsEmpty)
            {
                Line newLine = new Line(selectedPen, point1, point2);
                lines.Add(newLine);
                UndoStack.Push("Line");

                PaintCanvas.Refresh();

                point1 = Point.Empty;
                point2 = Point.Empty;
            }

            if (isPencilSelected || isEraserSelected || isPaintSelected || isCustom)
            {
                strokes.Add(currentStroke);
                UndoStack.Push("Stroke");

                PaintCanvas.Refresh();

                currentStroke = new Stroke(selectedPen, new List<Point>());
            }

            Cursor = Cursors.Default;
        }

        /*******************************************************
        * Paint event
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void PaintCanvas_Paint(object sender, PaintEventArgs e)
        {
            // Draw Lines
            if (lines.Count > 0)
            {
                foreach (Line line in lines)
                {
                    int x1 = line.StartPoint.X;
                    int y1 = line.StartPoint.Y;
                    int x2 = line.EndPoint.X;
                    int y2 = line.EndPoint.Y;

                    e.Graphics.DrawLine(line.PaintPen, x1, y1, x2, y2);
                }
            }

            // Draw Existing Pencil, PaintBrush, and Eraser Strokes
            if (strokes.Count > 0)
            {
                foreach (Stroke stroke in strokes)
                {
                    if (stroke.Points.Count > 1)
                    {
                        e.Graphics.DrawLines(stroke.PaintPen, stroke.Points.ToArray());
                    }
                }
            }

            // Live Painting of Pencil, PaintBrush, or Eraser
            if (currentStroke.Points.Count > 1)
            {
                e.Graphics.DrawLines(currentStroke.PaintPen, currentStroke.Points.ToArray());
            }
        }

        /*******************************************************
        * draw line button Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void LineButton_Click(object sender, EventArgs e)
        {
            isPencilSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;
            isCustom = false; 
            isLineSelected = true;

            selectedPen = new Pen(selectedColor, 1);


            textBox1.Text = "Draw Line";
        }

        /*******************************************************
        * Pencil button Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void PencilButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPaintSelected = false;
            isEraserSelected = false;
            isCustom = false;
            isPencilSelected = true;

            selectedPen = new Pen(selectedColor, 1);

            textBox1.Text = "Pencil"; 
        }

        /*******************************************************
        * brush button Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void BrushButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPencilSelected = false;
            isEraserSelected = false;
            isCustom = false;
            isPaintSelected = true;

            selectedPen = new Pen(selectedColor, 10);
            selectedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            selectedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            textBox1.Text = "Brush";
        }

        /*******************************************************
        * eraser button Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void EraserButton_Click(object sender, EventArgs e)
        {
            isLineSelected = false;
            isPencilSelected = false;
            isPaintSelected = false;
            isCustom = false;
            isEraserSelected = true;

            selectedPen = new Pen(PaintCanvas.BackColor, 10);

            textBox1.Text = "Eraser";
        }
        /*******************************************************
        * Undo button Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void UndoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Undo";
            if (UndoStack.Count > 0)
            {
                string action = UndoStack.Pop();
                PaintAction newAction;

                switch (action)
                {
                    case "Line":
                        newAction = lines[lines.Count - 1];
                        RedoStack.Push(newAction);

                        lines.RemoveAt(lines.Count - 1);
                        lines.TrimExcess();
                        break;
                    case "Stroke":
                        newAction = strokes[strokes.Count - 1];
                        RedoStack.Push(newAction);

                        strokes.RemoveAt(strokes.Count - 1);
                        strokes.TrimExcess();
                        break;
                    default:
                        Console.WriteLine("Undo Button Error!");
                        break;
                }
            }

            PaintCanvas.Refresh();
        }


        /*******************************************************
        * Redo button Click
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void RedoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Redo";

            if (RedoStack.Count > 0)
            {
                var action = RedoStack.Pop();

                if (action is Line)
                {
                    lines.Add((Line)action);
                    UndoStack.Push("Line");
                    PaintCanvas.Refresh();
                }

                if (action is Stroke)
                {
                    strokes.Add((Stroke)action);
                    UndoStack.Push("Stroke");
                    PaintCanvas.Refresh();
                }
            }
        }

        /*******************************************************
        * Developers File Menu
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void aboutTheDevelopersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About the Developers: \nJosh Ruge Tyler Saballus\nTheme Song: \nhttps://www.youtube.com/watch?v=9jK-NcRmVcw"); 
        }

        /*******************************************************
        * New File Menu
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lines.Clear();
            strokes.Clear();
            PaintCanvas.Image = null;
            PaintCanvas.Refresh();
        }

        /*******************************************************
        * Open File Menu
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.  
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Portable Network Graphics|*.png";
            openFileDialog1.Title = "Select a Cursor File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lines.Clear();
                strokes.Clear();

                PaintCanvas.Image = new Bitmap(openFileDialog1.FileName);
            }
            openFileDialog1.Dispose(); 
        }

        /*******************************************************
        * Save File Menu
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savePath != null)
            {
                Bitmap imageMap = new Bitmap(PaintCanvas.Width, PaintCanvas.Height);
                PaintCanvas.DrawToBitmap(imageMap, PaintCanvas.Bounds);

                PictureBox saveBox = new PictureBox();
                saveBox.Image = imageMap;

                //code to save the file;
                saveBox.Image.Save(savePath, ImageFormat.Png);
            } else
            {
                SaveFileDialog saveDialog1 = new SaveFileDialog();
                saveDialog1.Filter = "png (*.png)|*.png";

                DialogResult result = saveDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string fileName = saveDialog1.FileName;
                    savePath = fileName;

                    Bitmap imageMap = new Bitmap(PaintCanvas.Width, PaintCanvas.Height);
                    PaintCanvas.DrawToBitmap(imageMap, PaintCanvas.Bounds);

                    PictureBox saveBox = new PictureBox();
                    saveBox.Image = imageMap;

                    //code to save the file;
                    saveBox.Image.Save(fileName, ImageFormat.Png);
                }
            }
        }

        /*******************************************************
        * Save as File Menu
        *
        * Arguments: Object Sender and EventArgs e
        * Return Type: void
        * Use Case: 
        ******************************************************/
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Filter = "png (*.png)|*.png";
            DialogResult result = saveDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = saveDialog1.FileName;
                savePath = fileName;

                Bitmap imageMap = new Bitmap(PaintCanvas.Width, PaintCanvas.Height);
                PaintCanvas.DrawToBitmap(imageMap, PaintCanvas.Bounds);

                PictureBox saveBox = new PictureBox();
                saveBox.Image = imageMap;

                //code to save the file;
                saveBox.Image.Save(fileName, ImageFormat.Png); 
            }
        }

        private void SmallButton_Click(object sender, EventArgs e)
        {
            isMediumSelected = false;
            isLargeSelected = false;

            isSmallSelected = true;

            if (isPencilSelected || isLineSelected)
            {
                selectedPen = new Pen(selectedColor, 1);
            }

            if (isPaintSelected)
            {
                selectedPen = new Pen(selectedColor, 10);
                selectedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                selectedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            }

            if (isEraserSelected)
            {
                selectedPen = new Pen(PaintCanvas.BackColor, 10);
            }
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            isSmallSelected = false;
            isLargeSelected = false;

            isMediumSelected = true;


            if (isPencilSelected || isLineSelected)
            {
                selectedPen = new Pen(selectedColor, 2);
            }

            if (isPaintSelected)
            {
                selectedPen = new Pen(selectedColor, 20);
                selectedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                selectedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            }

            if (isEraserSelected)
            {
                selectedPen = new Pen(PaintCanvas.BackColor, 20);
            }
        }

        private void LargeButton_Click(object sender, EventArgs e)
        {
            isSmallSelected = false;
            isMediumSelected = false;

            isLargeSelected = true;


            if (isPencilSelected || isLineSelected)
            {
                selectedPen = new Pen(selectedColor, 3);
            }

            if (isPaintSelected)
            {
                selectedPen = new Pen(selectedColor, 30);
                selectedPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                selectedPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            }


            if (isEraserSelected)
            {
                selectedPen = new Pen(PaintCanvas.BackColor, 30);
            }
        }
    }
}