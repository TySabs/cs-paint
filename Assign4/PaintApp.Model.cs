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

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assign4
{
    public partial class PaintApp : Form
    {

        public List<Line> lines = new List<Line>();
        public List<Stroke> strokes = new List<Stroke>();
        public Stroke currentStroke = new Stroke(selectedPen, new List<Point>());

        private Stack<string> UndoStack = new Stack<string>();
        private Stack<PaintAction> RedoStack = new Stack<PaintAction>();

        private Point point1;
        private Point point2;

        private Color selectedColor = Color.Black;
        private static Pen selectedPen = new Pen(Color.Black);

        private bool isLineSelected = false;
        private bool isPencilSelected = false;
        private bool isPaintSelected = false;
        private bool isEraserSelected = false;

        private bool isSmallSelected = false;
        private bool isMediumSelected = false;
        private bool isLargeSelected = false;

        private bool isCustom = false; 
        private bool isSaved = false;

        private string savePath;
    }
}
