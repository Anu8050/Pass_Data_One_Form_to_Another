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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Can't empty");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = textBox2.Text;
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }
    }
}
