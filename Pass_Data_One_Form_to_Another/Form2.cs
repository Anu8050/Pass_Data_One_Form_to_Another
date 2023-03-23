using System;
using System.IO;
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

        private void button1_Click(object sender, EventArgs e)
        {

            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("C:\\Users\\User\\Documents\\Anusha.pdf", FileMode.Create));
            document.Open();
            label1.Text = Form1.SetValueForText1;
            label2.Text = Form1.SetValueForText2;
            label3.Text = Form1.SetValueForText3;
            String str = label1.Text + "\n" + label2.Text + "\n" + label3.Text;

            Paragraph p = new Paragraph(str);
            document.Add(p);
            document.Close();
        }
    }
}
