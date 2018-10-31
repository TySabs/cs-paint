using System;
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

        public Graphics g; 
        private Point point1;
        private Point point2;
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

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen linePen = new Pen(selectedColor); 
            point2 = e.Location;
            g = this.CreateGraphics(); 
            g.DrawLine(linePen, point1, point2); 
            
        }
    }
}
