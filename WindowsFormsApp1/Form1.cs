﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(this);
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6(this);
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7(this);
            newForm.Show();
        }
    }
}
