using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            VScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            Controls.Add(vScrollBar1);
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose a Folder to Watch";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void FolderBrowserDialog_Click(object sender, EventArgs e)
        {

        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal d = numericUpDown1.Value;
            int n = Convert.ToInt32(d);
            int f = 1;
            for ( int i=0; i<n; i++)
            {
                f = f * (i + 1);

            }
            textBox2.Text = f.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
