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

        public PaintApp()
        {
            InitializeComponent();
            InitFrameSize();
            CenterToScreen();
            fillBox(); 
        }

        private void InitFrameSize()
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height - 100;
            int w = Screen.PrimaryScreen.WorkingArea.Width - 300;
            Size = new Size(w, h);
        }

        private void fillBox()
        {
            infoCanvas.BackColor = Color.Black;
            textBox1.Text = "None Selected";
        }

    }
}
