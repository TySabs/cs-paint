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
        }

        private void InitFrameSize()
        {
            int h = Screen.PrimaryScreen.WorkingArea.Height - 200;
            int w = Screen.PrimaryScreen.WorkingArea.Width - 300;
            Size = new Size(w, h);
        }
    }
}
