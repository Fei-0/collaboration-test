﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collaboration_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= "Hello World!" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Collaboration Test";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        public int summary(int a,int b)
        {
            int s;
            s = a + b;
            return s;
        }
    }
}
