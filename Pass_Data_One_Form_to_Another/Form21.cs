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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error: " + e.RejectionHint.ToString() + "Position: " + e.Position.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Date: " + maskedTextBox1.Text);

        }

        private void maskedTextBox1_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(e.IsValidInput) 
            {
                DateTime dateTime = (DateTime)e.ReturnValue;
                MessageBox.Show("Validated Date: " + dateTime.ToShortDateString());
            }
            else
            {
                MessageBox.Show("InValidated Date: " + maskedTextBox1.Text.ToString());
            }   
        }
    }
}
