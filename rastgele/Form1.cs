﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            label1.Text = rastgele.Next(0, 100).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            label1.Text = rastgele.Next(0, 100).ToString();
        }
    }
}
