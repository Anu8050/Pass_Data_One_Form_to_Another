using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        
        List<Classes.Items> lsItems = new List<Classes.Items>();    

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Items item = new Classes.Items();
            item.itemCode = "HP00" + (lsItems.Count + 1);
            item.itemName = "Computer" + item.itemCode;
            bindingSource1.Add(item);
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = lsItems;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(lsItems.Count > 0)
            {
                bindingSource1.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            
        }
    }
}
