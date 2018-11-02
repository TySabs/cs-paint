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

    }
}
