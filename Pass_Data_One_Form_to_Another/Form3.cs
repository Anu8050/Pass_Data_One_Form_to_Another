using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Pass_Data_One_Form_to_Another
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1_TextChanged(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox dynamicRichTextBox = new RichTextBox();
            dynamicRichTextBox.Location = new Point(202, 200);
            dynamicRichTextBox.Width = 300;
            dynamicRichTextBox.Height = 200;
            dynamicRichTextBox.BackColor = Color.Red;
            dynamicRichTextBox.ForeColor = Color.Blue;
            dynamicRichTextBox.Text = "I am Dynamic RichTextBox";
            dynamicRichTextBox.Name = "DynamicRichTextBox";
            dynamicRichTextBox.Font = new Font("Georgia", 16);
            Controls.Add(dynamicRichTextBox);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
