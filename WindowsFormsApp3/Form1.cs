using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=4; i++)
            {
                int kuvvet = 10;
                for (int k = 1; k <= i; k++)
                {
                    kuvvet *= 10;
                }
                listBox1.Items.Add(kuvvet);
            }
        }
    }
}
