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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipText = "Hi..";
            notifyIcon1.BalloonTipTitle = "Alert..";
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.ShowBalloonTip(500);
        }
    }
}
