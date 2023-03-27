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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Manipur");
            comboBox1.Items.Add("Punjab");
            comboBox1.Items.Add("Sikkim");
        }
    }
}
