﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //When the textbox is not filled , it'll show an error message//
            if (txtStudentName.Text =="" || txtTutorClass.Text =="" )
            {
                MessageBox.Show("Please Enter Your Name Or Tutor Class Again","Message");
            }
            //If it's filled, it would move to next form//
            else
            {
                this.Hide();
                Homepage f2 = new Homepage();
                f2.ShowDialog();
                this.Close();
            }
        }
    }
}
