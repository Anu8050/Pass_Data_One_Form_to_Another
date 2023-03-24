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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = hScrollBar1.Value.ToString();
            changeClr();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            changeClr();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            changeClr();
        }

        private void changeClr()
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value,hScrollBar2.Value,hScrollBar3.Value);

        }
    }
}
