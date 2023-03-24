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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            VScrollBar vScrollBar1 = new VScrollBar();
            vScrollBar1.Dock = DockStyle.Right;
            Controls.Add(vScrollBar1);
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose a Folder to Watch";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void FolderBrowserDialog_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NotifyIcon trayIcon = new NotifyIcon();
            trayIcon.Icon = new Icon(@"C://Users//User//Downloads//home.ico");
            trayIcon.Text = "New message";
            trayIcon.Visible = true;
            trayIcon.ShowBalloonTip(2000, "Information", "A new message received!", ToolTipIcon.Info);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown(); 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(228, 20);
            this.numericUpDown1.TabIndex = 0;
        }
    }
}
