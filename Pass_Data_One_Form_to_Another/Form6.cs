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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal d = numericUpDown1.Value;
            int n = Convert.ToInt32(d);
            int f = 1;
            for (int i = 0; i < n; i++)
            {
                f = f * (i + 1);

            }
            textBox1.Text = f.ToString();
        }
    }
}
