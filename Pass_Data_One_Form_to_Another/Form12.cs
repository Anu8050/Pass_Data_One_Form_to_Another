﻿using System;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            usersBindingSource.Add(new Users()
            {
                Name = "Anusha",
                Password = "1234",
            });
            usersBindingSource.Add(new Users()
            {
                Name = "Divya",
                Password = "Div123",
            });
            usersBindingSource.Add(new Users()
            {
                Name = "Vijet",
                Password = "vijet123",
            });

        }
    }
}
