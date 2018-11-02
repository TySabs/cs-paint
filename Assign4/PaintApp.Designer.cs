using System.Windows.Forms;

namespace Assign4
{
    partial class PaintApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlackBox = new System.Windows.Forms.TextBox();
            this.GrayBox = new System.Windows.Forms.TextBox();
            this.OliveBox = new System.Windows.Forms.TextBox();
            this.MaroonBox = new System.Windows.Forms.TextBox();
            this.PurpleBox = new System.Windows.Forms.TextBox();
            this.NavyBox = new System.Windows.Forms.TextBox();
            this.TealBox = new System.Windows.Forms.TextBox();
            this.GreenBox = new System.Windows.Forms.TextBox();
            this.SiennaBox = new System.Windows.Forms.TextBox();
            this.BlueVioletBox = new System.Windows.Forms.TextBox();
            this.SteelBlueBox = new System.Windows.Forms.TextBox();
            this.DeepSkyBlueBox = new System.Windows.Forms.TextBox();
            this.DarkSlateGrayBox = new System.Windows.Forms.TextBox();
            this.DarkKhakiBox = new System.Windows.Forms.TextBox();
            this.SandyBrownBox = new System.Windows.Forms.TextBox();
            this.DeepPinkBox = new System.Windows.Forms.TextBox();
            this.MediumSlateBlueBox = new System.Windows.Forms.TextBox();
            this.PowderBlueBox = new System.Windows.Forms.TextBox();
            this.SpringGreenBox = new System.Windows.Forms.TextBox();
            this.LemonChiffonBox = new System.Windows.Forms.TextBox();
            this.FuchsiaBox = new System.Windows.Forms.TextBox();
            this.BlueBox = new System.Windows.Forms.TextBox();
            this.AquaBox = new System.Windows.Forms.TextBox();
            this.LimeBox = new System.Windows.Forms.TextBox();
            this.YellowBox = new System.Windows.Forms.TextBox();
            this.RedBox = new System.Windows.Forms.TextBox();
            this.SilverBox = new System.Windows.Forms.TextBox();
            this.WhiteBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentlyOpenedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheDevelopersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.UndoButton = new System.Windows.Forms.Button();
            this.RedoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LargeButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.SmallButton = new System.Windows.Forms.Button();
            this.infoCanvas = new System.Windows.Forms.PictureBox();
            this.PencilButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.EraserButton = new System.Windows.Forms.Button();
            this.BrushButton = new System.Windows.Forms.Button();
            this.PaintCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackBox
            // 
            this.BlackBox.BackColor = System.Drawing.Color.Black;
            this.BlackBox.Location = new System.Drawing.Point(12, 63);
            this.BlackBox.Multiline = true;
            this.BlackBox.Name = "BlackBox";
            this.BlackBox.ReadOnly = true;
            this.BlackBox.Size = new System.Drawing.Size(34, 36);
            this.BlackBox.TabIndex = 0;
            this.BlackBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // GrayBox
            // 
            this.GrayBox.BackColor = System.Drawing.Color.Gray;
            this.GrayBox.Location = new System.Drawing.Point(57, 63);
            this.GrayBox.Multiline = true;
            this.GrayBox.Name = "GrayBox";
            this.GrayBox.Size = new System.Drawing.Size(34, 36);
            this.GrayBox.TabIndex = 1;
            this.GrayBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // OliveBox
            // 
            this.OliveBox.BackColor = System.Drawing.Color.Olive;
            this.OliveBox.Location = new System.Drawing.Point(145, 63);
            this.OliveBox.Multiline = true;
            this.OliveBox.Name = "OliveBox";
            this.OliveBox.Size = new System.Drawing.Size(34, 36);
            this.OliveBox.TabIndex = 3;
            this.OliveBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // MaroonBox
            // 
            this.MaroonBox.BackColor = System.Drawing.Color.Maroon;
            this.MaroonBox.Location = new System.Drawing.Point(102, 63);
            this.MaroonBox.Multiline = true;
            this.MaroonBox.Name = "MaroonBox";
            this.MaroonBox.Size = new System.Drawing.Size(34, 36);
            this.MaroonBox.TabIndex = 2;
            this.MaroonBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // PurpleBox
            // 
            this.PurpleBox.BackColor = System.Drawing.Color.Purple;
            this.PurpleBox.Location = new System.Drawing.Point(325, 63);
            this.PurpleBox.Multiline = true;
            this.PurpleBox.Name = "PurpleBox";
            this.PurpleBox.Size = new System.Drawing.Size(34, 36);
            this.PurpleBox.TabIndex = 7;
            this.PurpleBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // NavyBox
            // 
            this.NavyBox.BackColor = System.Drawing.Color.Navy;
            this.NavyBox.Location = new System.Drawing.Point(281, 63);
            this.NavyBox.Multiline = true;
            this.NavyBox.Name = "NavyBox";
            this.NavyBox.Size = new System.Drawing.Size(34, 36);
            this.NavyBox.TabIndex = 6;
            this.NavyBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // TealBox
            // 
            this.TealBox.BackColor = System.Drawing.Color.Teal;
            this.TealBox.Location = new System.Drawing.Point(237, 63);
            this.TealBox.Multiline = true;
            this.TealBox.Name = "TealBox";
            this.TealBox.Size = new System.Drawing.Size(34, 36);
            this.TealBox.TabIndex = 5;
            this.TealBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // GreenBox
            // 
            this.GreenBox.BackColor = System.Drawing.Color.Green;
            this.GreenBox.Location = new System.Drawing.Point(190, 63);
            this.GreenBox.Multiline = true;
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(34, 36);
            this.GreenBox.TabIndex = 4;
            this.GreenBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // SiennaBox
            // 
            this.SiennaBox.BackColor = System.Drawing.Color.Sienna;
            this.SiennaBox.Location = new System.Drawing.Point(592, 63);
            this.SiennaBox.Multiline = true;
            this.SiennaBox.Name = "SiennaBox";
            this.SiennaBox.Size = new System.Drawing.Size(34, 36);
            this.SiennaBox.TabIndex = 13;
            this.SiennaBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // BlueVioletBox
            // 
            this.BlueVioletBox.BackColor = System.Drawing.Color.BlueViolet;
            this.BlueVioletBox.Location = new System.Drawing.Point(550, 63);
            this.BlueVioletBox.Multiline = true;
            this.BlueVioletBox.Name = "BlueVioletBox";
            this.BlueVioletBox.Size = new System.Drawing.Size(34, 36);
            this.BlueVioletBox.TabIndex = 12;
            this.BlueVioletBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // SteelBlueBox
            // 
            this.SteelBlueBox.BackColor = System.Drawing.Color.SteelBlue;
            this.SteelBlueBox.Location = new System.Drawing.Point(507, 63);
            this.SteelBlueBox.Multiline = true;
            this.SteelBlueBox.Name = "SteelBlueBox";
            this.SteelBlueBox.Size = new System.Drawing.Size(34, 36);
            this.SteelBlueBox.TabIndex = 11;
            this.SteelBlueBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // DeepSkyBlueBox
            // 
            this.DeepSkyBlueBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeepSkyBlueBox.Location = new System.Drawing.Point(462, 63);
            this.DeepSkyBlueBox.Multiline = true;
            this.DeepSkyBlueBox.Name = "DeepSkyBlueBox";
            this.DeepSkyBlueBox.Size = new System.Drawing.Size(34, 36);
            this.DeepSkyBlueBox.TabIndex = 10;
            this.DeepSkyBlueBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // DarkSlateGrayBox
            // 
            this.DarkSlateGrayBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DarkSlateGrayBox.Location = new System.Drawing.Point(417, 63);
            this.DarkSlateGrayBox.Multiline = true;
            this.DarkSlateGrayBox.Name = "DarkSlateGrayBox";
            this.DarkSlateGrayBox.Size = new System.Drawing.Size(34, 36);
            this.DarkSlateGrayBox.TabIndex = 9;
            this.DarkSlateGrayBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // DarkKhakiBox
            // 
            this.DarkKhakiBox.BackColor = System.Drawing.Color.DarkKhaki;
            this.DarkKhakiBox.Location = new System.Drawing.Point(370, 63);
            this.DarkKhakiBox.Multiline = true;
            this.DarkKhakiBox.Name = "DarkKhakiBox";
            this.DarkKhakiBox.Size = new System.Drawing.Size(34, 36);
            this.DarkKhakiBox.TabIndex = 8;
            this.DarkKhakiBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // SandyBrownBox
            // 
            this.SandyBrownBox.BackColor = System.Drawing.Color.SandyBrown;
            this.SandyBrownBox.Location = new System.Drawing.Point(592, 108);
            this.SandyBrownBox.Multiline = true;
            this.SandyBrownBox.Name = "SandyBrownBox";
            this.SandyBrownBox.Size = new System.Drawing.Size(34, 36);
            this.SandyBrownBox.TabIndex = 27;
            this.SandyBrownBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // DeepPinkBox
            // 
            this.DeepPinkBox.BackColor = System.Drawing.Color.DeepPink;
            this.DeepPinkBox.Location = new System.Drawing.Point(550, 108);
            this.DeepPinkBox.Multiline = true;
            this.DeepPinkBox.Name = "DeepPinkBox";
            this.DeepPinkBox.Size = new System.Drawing.Size(34, 36);
            this.DeepPinkBox.TabIndex = 26;
            this.DeepPinkBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // MediumSlateBlueBox
            // 
            this.MediumSlateBlueBox.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.MediumSlateBlueBox.Location = new System.Drawing.Point(507, 108);
            this.MediumSlateBlueBox.Multiline = true;
            this.MediumSlateBlueBox.Name = "MediumSlateBlueBox";
            this.MediumSlateBlueBox.Size = new System.Drawing.Size(34, 36);
            this.MediumSlateBlueBox.TabIndex = 25;
            this.MediumSlateBlueBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // PowderBlueBox
            // 
            this.PowderBlueBox.BackColor = System.Drawing.Color.PowderBlue;
            this.PowderBlueBox.Location = new System.Drawing.Point(462, 108);
            this.PowderBlueBox.Multiline = true;
            this.PowderBlueBox.Name = "PowderBlueBox";
            this.PowderBlueBox.Size = new System.Drawing.Size(34, 36);
            this.PowderBlueBox.TabIndex = 24;
            this.PowderBlueBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // SpringGreenBox
            // 
            this.SpringGreenBox.BackColor = System.Drawing.Color.SpringGreen;
            this.SpringGreenBox.Location = new System.Drawing.Point(417, 108);
            this.SpringGreenBox.Multiline = true;
            this.SpringGreenBox.Name = "SpringGreenBox";
            this.SpringGreenBox.Size = new System.Drawing.Size(34, 36);
            this.SpringGreenBox.TabIndex = 23;
            this.SpringGreenBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // LemonChiffonBox
            // 
            this.LemonChiffonBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.LemonChiffonBox.Location = new System.Drawing.Point(370, 108);
            this.LemonChiffonBox.Multiline = true;
            this.LemonChiffonBox.Name = "LemonChiffonBox";
            this.LemonChiffonBox.Size = new System.Drawing.Size(34, 36);
            this.LemonChiffonBox.TabIndex = 22;
            this.LemonChiffonBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // FuchsiaBox
            // 
            this.FuchsiaBox.BackColor = System.Drawing.Color.Fuchsia;
            this.FuchsiaBox.Location = new System.Drawing.Point(325, 108);
            this.FuchsiaBox.Multiline = true;
            this.FuchsiaBox.Name = "FuchsiaBox";
            this.FuchsiaBox.Size = new System.Drawing.Size(34, 36);
            this.FuchsiaBox.TabIndex = 21;
            this.FuchsiaBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // BlueBox
            // 
            this.BlueBox.BackColor = System.Drawing.Color.Blue;
            this.BlueBox.Location = new System.Drawing.Point(281, 108);
            this.BlueBox.Multiline = true;
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(34, 36);
            this.BlueBox.TabIndex = 20;
            this.BlueBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // AquaBox
            // 
            this.AquaBox.BackColor = System.Drawing.Color.Aqua;
            this.AquaBox.Location = new System.Drawing.Point(237, 108);
            this.AquaBox.Multiline = true;
            this.AquaBox.Name = "AquaBox";
            this.AquaBox.Size = new System.Drawing.Size(34, 36);
            this.AquaBox.TabIndex = 19;
            this.AquaBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // LimeBox
            // 
            this.LimeBox.BackColor = System.Drawing.Color.Lime;
            this.LimeBox.Location = new System.Drawing.Point(190, 108);
            this.LimeBox.Multiline = true;
            this.LimeBox.Name = "LimeBox";
            this.LimeBox.Size = new System.Drawing.Size(34, 36);
            this.LimeBox.TabIndex = 18;
            this.LimeBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // YellowBox
            // 
            this.YellowBox.BackColor = System.Drawing.Color.Yellow;
            this.YellowBox.Location = new System.Drawing.Point(145, 108);
            this.YellowBox.Multiline = true;
            this.YellowBox.Name = "YellowBox";
            this.YellowBox.Size = new System.Drawing.Size(34, 36);
            this.YellowBox.TabIndex = 17;
            this.YellowBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Red;
            this.RedBox.Location = new System.Drawing.Point(102, 108);
            this.RedBox.Multiline = true;
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(34, 36);
            this.RedBox.TabIndex = 16;
            this.RedBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // SilverBox
            // 
            this.SilverBox.BackColor = System.Drawing.Color.Silver;
            this.SilverBox.Location = new System.Drawing.Point(57, 108);
            this.SilverBox.Multiline = true;
            this.SilverBox.Name = "SilverBox";
            this.SilverBox.Size = new System.Drawing.Size(34, 36);
            this.SilverBox.TabIndex = 15;
            this.SilverBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // WhiteBox
            // 
            this.WhiteBox.BackColor = System.Drawing.Color.White;
            this.WhiteBox.Location = new System.Drawing.Point(12, 108);
            this.WhiteBox.Multiline = true;
            this.WhiteBox.Name = "WhiteBox";
            this.WhiteBox.Size = new System.Drawing.Size(34, 36);
            this.WhiteBox.TabIndex = 14;
            this.WhiteBox.Click += new System.EventHandler(this.Box_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1246, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.recentlyOpenedToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // recentlyOpenedToolStripMenuItem
            // 
            this.recentlyOpenedToolStripMenuItem.Name = "recentlyOpenedToolStripMenuItem";
            this.recentlyOpenedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentlyOpenedToolStripMenuItem.Text = "Recently Opened";
            this.recentlyOpenedToolStripMenuItem.Click += new System.EventHandler(this.recentlyOpenedToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheDevelopersToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutTheDevelopersToolStripMenuItem
            // 
            this.aboutTheDevelopersToolStripMenuItem.Name = "aboutTheDevelopersToolStripMenuItem";
            this.aboutTheDevelopersToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aboutTheDevelopersToolStripMenuItem.Text = "About the Developers";
            this.aboutTheDevelopersToolStripMenuItem.Click += new System.EventHandler(this.aboutTheDevelopersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Please Choose a Color:";
            // 
            // UndoButton
            // 
            this.UndoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UndoButton.Location = new System.Drawing.Point(900, 54);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(95, 23);
            this.UndoButton.TabIndex = 31;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedoButton.Location = new System.Drawing.Point(900, 85);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(95, 23);
            this.RedoButton.TabIndex = 32;
            this.RedoButton.Text = "Redo";
            this.RedoButton.UseVisualStyleBackColor = true;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Choose a Tool:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(997, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Color Selection:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1123, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Feature:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1123, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(767, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Stroke Size:";
            // 
            // LargeButton
            // 
            this.LargeButton.BackgroundImage = global::Assign4.Properties.Resources.large;
            this.LargeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LargeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LargeButton.Location = new System.Drawing.Point(837, 57);
            this.LargeButton.Margin = new System.Windows.Forms.Padding(1);
            this.LargeButton.Name = "LargeButton";
            this.LargeButton.Size = new System.Drawing.Size(31, 32);
            this.LargeButton.TabIndex = 49;
            this.LargeButton.UseVisualStyleBackColor = true;
            // 
            // MediumButton
            // 
            this.MediumButton.BackgroundImage = global::Assign4.Properties.Resources.medium;
            this.MediumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MediumButton.Location = new System.Drawing.Point(798, 57);
            this.MediumButton.Margin = new System.Windows.Forms.Padding(1);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(31, 32);
            this.MediumButton.TabIndex = 47;
            this.MediumButton.UseVisualStyleBackColor = true;
            // 
            // SmallButton
            // 
            this.SmallButton.BackgroundImage = global::Assign4.Properties.Resources.small;
            this.SmallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SmallButton.Location = new System.Drawing.Point(761, 57);
            this.SmallButton.Margin = new System.Windows.Forms.Padding(1);
            this.SmallButton.Name = "SmallButton";
            this.SmallButton.Size = new System.Drawing.Size(31, 32);
            this.SmallButton.TabIndex = 46;
            this.SmallButton.UseVisualStyleBackColor = true;
            // 
            // infoCanvas
            // 
            this.infoCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.infoCanvas.Location = new System.Drawing.Point(1001, 57);
            this.infoCanvas.Name = "infoCanvas";
            this.infoCanvas.Size = new System.Drawing.Size(116, 23);
            this.infoCanvas.TabIndex = 39;
            this.infoCanvas.TabStop = false;
            // 
            // PencilButton
            // 
            this.PencilButton.BackgroundImage = global::Assign4.Properties.Resources.pencil;
            this.PencilButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PencilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PencilButton.Location = new System.Drawing.Point(649, 108);
            this.PencilButton.Name = "PencilButton";
            this.PencilButton.Size = new System.Drawing.Size(41, 43);
            this.PencilButton.TabIndex = 36;
            this.PencilButton.UseVisualStyleBackColor = true;
            this.PencilButton.Click += new System.EventHandler(this.PencilButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.BackgroundImage = global::Assign4.Properties.Resources.line;
            this.LineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineButton.Location = new System.Drawing.Point(649, 54);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(41, 43);
            this.LineButton.TabIndex = 35;
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.BackgroundImage = global::Assign4.Properties.Resources.eraser;
            this.EraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EraserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraserButton.Location = new System.Drawing.Point(702, 108);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(41, 43);
            this.EraserButton.TabIndex = 34;
            this.EraserButton.UseVisualStyleBackColor = true;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // BrushButton
            // 
            this.BrushButton.BackgroundImage = global::Assign4.Properties.Resources.brush;
            this.BrushButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrushButton.Location = new System.Drawing.Point(702, 54);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(41, 43);
            this.BrushButton.TabIndex = 33;
            this.BrushButton.UseVisualStyleBackColor = true;
            this.BrushButton.Click += new System.EventHandler(this.BrushButton_Click);
            // 
            // PaintCanvas
            // 
            this.PaintCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaintCanvas.Location = new System.Drawing.Point(12, 157);
            this.PaintCanvas.Name = "PaintCanvas";
            this.PaintCanvas.Size = new System.Drawing.Size(1219, 513);
            this.PaintCanvas.TabIndex = 30;
            this.PaintCanvas.TabStop = false;
            this.PaintCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCanvas_Paint);
            this.PaintCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintCanvas_MouseDown);
            this.PaintCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintCanvas_MouseMove);
            this.PaintCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintCanvas_MouseUp);
            // 
            // PaintApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 811);
            this.Controls.Add(this.LargeButton);
            this.Controls.Add(this.MediumButton);
            this.Controls.Add(this.SmallButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoCanvas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PencilButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.EraserButton);
            this.Controls.Add(this.BrushButton);
            this.Controls.Add(this.RedoButton);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.PaintCanvas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SandyBrownBox);
            this.Controls.Add(this.DeepPinkBox);
            this.Controls.Add(this.MediumSlateBlueBox);
            this.Controls.Add(this.PowderBlueBox);
            this.Controls.Add(this.SpringGreenBox);
            this.Controls.Add(this.LemonChiffonBox);
            this.Controls.Add(this.FuchsiaBox);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.AquaBox);
            this.Controls.Add(this.LimeBox);
            this.Controls.Add(this.YellowBox);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.SilverBox);
            this.Controls.Add(this.WhiteBox);
            this.Controls.Add(this.SiennaBox);
            this.Controls.Add(this.BlueVioletBox);
            this.Controls.Add(this.SteelBlueBox);
            this.Controls.Add(this.DeepSkyBlueBox);
            this.Controls.Add(this.DarkSlateGrayBox);
            this.Controls.Add(this.DarkKhakiBox);
            this.Controls.Add(this.PurpleBox);
            this.Controls.Add(this.NavyBox);
            this.Controls.Add(this.TealBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.OliveBox);
            this.Controls.Add(this.MaroonBox);
            this.Controls.Add(this.GrayBox);
            this.Controls.Add(this.BlackBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintApp";
            this.Text = "Josh and Tyler\'s Ode to Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BlackBox;
        private System.Windows.Forms.TextBox GrayBox;
        private System.Windows.Forms.TextBox OliveBox;
        private System.Windows.Forms.TextBox MaroonBox;
        private System.Windows.Forms.TextBox PurpleBox;
        private System.Windows.Forms.TextBox NavyBox;
        private System.Windows.Forms.TextBox TealBox;
        private System.Windows.Forms.TextBox GreenBox;
        private System.Windows.Forms.TextBox SiennaBox;
        private System.Windows.Forms.TextBox BlueVioletBox;
        private System.Windows.Forms.TextBox SteelBlueBox;
        private System.Windows.Forms.TextBox DeepSkyBlueBox;
        private System.Windows.Forms.TextBox DarkSlateGrayBox;
        private System.Windows.Forms.TextBox DarkKhakiBox;
        private System.Windows.Forms.TextBox SandyBrownBox;
        private System.Windows.Forms.TextBox DeepPinkBox;
        private System.Windows.Forms.TextBox MediumSlateBlueBox;
        private System.Windows.Forms.TextBox PowderBlueBox;
        private System.Windows.Forms.TextBox SpringGreenBox;
        private System.Windows.Forms.TextBox LemonChiffonBox;
        private System.Windows.Forms.TextBox FuchsiaBox;
        private System.Windows.Forms.TextBox BlueBox;
        private System.Windows.Forms.TextBox AquaBox;
        private System.Windows.Forms.TextBox LimeBox;
        private System.Windows.Forms.TextBox YellowBox;
        private System.Windows.Forms.TextBox RedBox;
        private System.Windows.Forms.TextBox SilverBox;
        private System.Windows.Forms.TextBox WhiteBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PaintCanvas;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentlyOpenedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheDevelopersToolStripMenuItem;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button RedoButton;
        private System.Windows.Forms.Button EraserButton;
        private System.Windows.Forms.Button BrushButton;
        private System.Windows.Forms.Button PencilButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox infoCanvas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private Button SmallButton;
        private Button MediumButton;
        private Button LargeButton;
    }
}

