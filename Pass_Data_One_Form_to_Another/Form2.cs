using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
            label2.Text = Form1.SetValueForText2;
            label3.Text = Form1.SetValueForText3;
        }
    }
}
