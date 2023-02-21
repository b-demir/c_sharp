using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int i = 0;

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            i += 25;
            label1.Text = "puan : " + i.ToString();
            pictureBox61.Visible = true;
            if (i == 100)
            {
                MessageBox.Show("Tebrikler oyunu bitirdiniz.");
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            i += 25;
            label1.Text = "puan : " + i.ToString();
            pictureBox62.Visible = true;
            if (i == 100)
            {
                MessageBox.Show("Tebrikler oyunu bitirdiniz.");
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            i += 25;
            label1.Text = "puan : " + i.ToString();
            pictureBox63.Visible = true;
            if (i == 100)
            {
                MessageBox.Show("Tebrikler oyunu bitirdiniz.");
            }
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        { 
            i += 25;
            label1.Text = "puan : " + i.ToString();
            pictureBox64.Visible = true;
            if (i == 100)
            {
                MessageBox.Show("Tebrikler oyunu bitirdiniz.");
            }
        }
    }
}
