﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incerc7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();

            f.Show();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
