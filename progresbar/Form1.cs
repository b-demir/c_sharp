using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progresbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int derece = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            derece += 5;
            if (derece <= 0)
            {
                progressBar1.Value = 0;
            }
            if (derece >= 0 && derece<=20)
            {
                progressBar1.Value = 20;
            }
            if (derece >= 21 && derece <= 40)
            {
                progressBar1.Value = 40;
            }
            if (derece >= 41 && derece <= 60)
            {
                progressBar1.Value = 60;
            }
            if (derece >= 61 && derece <= 80)
            {
                progressBar1.Value = 80;
            }
            if (derece >= 81 && derece <= 99)
            {
                progressBar1.Value = 95;
            }
            if (derece>=100)
            {
                progressBar1.Value = 100;
            }
            label1.Text = derece.ToString() + " derece";
            if (derece <= 0)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (derece>0 && derece <100)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            derece -= 5;
            if (derece <= 0)
            {
                progressBar1.Value = 0;
            }
            if (derece >= 0 && derece <= 20)
            {
                progressBar1.Value = 20;
            }
            if (derece >= 21 && derece <= 40)
            {
                progressBar1.Value = 40;
            }
            if (derece >= 41 && derece <= 60)
            {
                progressBar1.Value = 60;
            }
            if (derece >= 61 && derece <= 80)
            {
                progressBar1.Value = 80;
            }
            if (derece >= 81 && derece <= 99)
            {
                progressBar1.Value = 95;
            }
            if (derece >= 100)
            {
                progressBar1.Value = 100;
            }
            label1.Text = derece.ToString() + " derece";
            if (derece <= 0)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
            }
            else if (derece > 0 && derece < 100)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
            }
        }
    }
}
