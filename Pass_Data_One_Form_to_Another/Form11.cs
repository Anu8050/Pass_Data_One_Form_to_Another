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
            comboBox1.SelectedIndex = 1;
            comboBox2.Items.Clear();
            List<State> list = new List<State>();
            list.Add(new State() { ID = 1, Name = "Manipur" });
            list.Add(new State() { ID = 2, Name = "Punjab" });
            list.Add(new State() { ID = 3, Name = "Sikkim" });
            comboBox2.DataSource = list;
            comboBox2.ValueMember = "ID";
            comboBox2.DisplayMember = "Name";

        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            State obj = comboBox2.SelectedItem as State;
            if(obj != null) 
                label6.Text = obj.Name;

            
        }
    }
}
