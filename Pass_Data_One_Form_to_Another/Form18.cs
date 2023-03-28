using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Name = "PrintPreviewControl1";
            printPreviewControl1.Dock = DockStyle.Fill;
            printPreviewControl1.Location = new Point(88, 80);
            printPreviewControl1.Document = new PrintDocument();
            printPreviewControl1.Document.DocumentName = "D:\\";
            printPreviewControl1.UseAntiAlias = true;
            Controls.Add(this.printPreviewControl1);
        }
        
    }
}
