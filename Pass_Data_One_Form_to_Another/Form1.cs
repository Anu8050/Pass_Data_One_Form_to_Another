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
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;

            Form2 form2 = new Form2();  
            form2.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker d = new DateTimePicker();
            d.Location = new Point(360, 162);
            d.Size = new Size(292, 26);
            d.MaxDate = new DateTime(2024, 12, 20);
            d.MinDate = new DateTime(2020, 1, 1);
            d.Format = DateTimePickerFormat.Long;
            d.Name = "MyPicker";
            d.Font = new Font("Comic Sans MS", 12);
            d.Visible = true;
            d.Value = DateTime.Today;
            this.Controls.Add(d);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                textBox4.ForeColor = colorDlg.Color;
                listBox1.ForeColor = colorDlg.Color;
                button2.ForeColor = colorDlg.Color;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            ImageList photoList = new ImageList();
            photoList.TransparentColor = Color.Red;
            photoList.ColorDepth = ColorDepth.Depth32Bit;
            photoList.ImageSize = new Size(200,200);
            photoList.Images.Add(Image.FromFile(@"C:\Users\User\Desktop\db_new_prj.png"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\User\Desktop\db_new_prj_Database.png"));
            photoList.Images.Add(Image.FromFile(@"C:\Users\User\Desktop\db_new_prj2.png"));
            for (int count = 0; count < photoList.Images.Count; count++)

            {

                photoList.Draw(g, new Point(200, 200), count);
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);

            }
        }
    }
}
