﻿using System;
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

    public partial class Form1 : Form
    {
        public Stack leftStack = new Stack();
        public Stack rightStack = new Stack();
        public Graphics g; 
        public Point point1;
        public Point point2;
        public Color selectedColor = Color.Black; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Box_Click(object sender, EventArgs e)
        {
            TextBox temp = sender as TextBox; 

  //          pictureBox1.BackColor = temp.BackColor;
            selectedColor = temp.BackColor; 

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point1 = e.Location; 
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
    //        if (movingMouse)

        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            point2 = e.Location;
            Pen linePen = new Pen(selectedColor);
            g = this.CreateGraphics();
            //    e.Graphics.DrawLine
            g.DrawLine(linePen, point1, point2);

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
