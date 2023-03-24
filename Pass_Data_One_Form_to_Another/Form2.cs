using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ceTe.DynamicPDF.Merger;


namespace Pass_Data_One_Form_to_Another
{
    public partial class Form2 : System.Windows.Forms.Form
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

        private void button1_Click(object sender, EventArgs e)
        {

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("C:\\Users\\User\\Documents\\Anusha.pdf", FileMode.Create));
            document.Open();
            label1.Text = Form1.SetValueForText1;
            label2.Text = Form1.SetValueForText2;
            label3.Text = Form1.SetValueForText3;
            label3.Text = Form1.SetValueForText3;
            String str = label1.Text + "\n" + label2.Text + "\n" + label3.Text;

            Paragraph p = new Paragraph(str);
            document.Add(p);
            document.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select first pdf file";
            fdlg.InitialDirectory = @"C://Users//User//Documents//";
            //Only allow pdf files
            fdlg.Filter = "Pdf Files (*.pdf) |*.pdf";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select first pdf file";
            fdlg.InitialDirectory = @"C://Users//User//Documents//";
            //Only allow pdf files
            fdlg.Filter = "Pdf Files (*.pdf) |*.pdf";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fdlg.FileName;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MergeDocument document = new MergeDocument(textBox1.Text);
            document.Append(textBox2.Text);
            document.Append(textBox3.Text);
            document.Draw("C://Users//User//Documents//text.pdf");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select first pdf file";
            fdlg.InitialDirectory = @"C://Users//User//Documents//";
            //Only allow pdf files
            fdlg.Filter = "Pdf Files (*.pdf) |*.pdf";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = fdlg.FileName;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
