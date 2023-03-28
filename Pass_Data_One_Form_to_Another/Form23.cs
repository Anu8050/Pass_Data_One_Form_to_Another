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
    public partial class Form23 : Form
    {
        private PerformanceCounter cpuCounter;
        public Form23()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            timer1.Start();
        }
        
        private void Form23_Load(object sender, EventArgs e)
        {

        }
       

        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float tmp = cpuCounter.NextValue();
            textBox1.Text = String.Format("{0} %", tmp);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 20), Brushes.Black, 12, 20);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
