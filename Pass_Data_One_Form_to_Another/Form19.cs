using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("excel");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("winword");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }
    }
}
