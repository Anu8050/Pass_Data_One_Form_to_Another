﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuStrip MainMenu = new MenuStrip();
            MainMenu.BackColor = Color.OrangeRed;
            MainMenu.ForeColor = Color.Black;
            MainMenu.Text ="File Menu";
            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);
            MainMenu.Name = "MainMenu";
            MainMenu.Dock = DockStyle.Left;
            this.Controls.Add(MainMenu);
            ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");
            FileMenu.ForeColor = Color.Black;
            FileMenu.Text = " Menu";
            FileMenu.TextAlign = ContentAlignment.BottomRight;
            FileMenu.ToolTipText = "Click Me";
            MainMenu.Items.Add(FileMenu);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void hiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
