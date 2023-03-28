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
    }
}
