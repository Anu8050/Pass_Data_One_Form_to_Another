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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in checkedListBox1.CheckedItems)
                listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for(int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
                listBox2.Items.Add(checkedListBox1.CheckedIndices[i]);

        }
    }
}
