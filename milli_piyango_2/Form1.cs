using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milli_piyango_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool a1 = false, a2 = false, a3 = false, a4 = false, a5 = false, a6 = false, a7 = false, so = false;
        int say = 0, dur = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            a1 = false;
            a2 = false;
            a3 = false;
            a4 = false;
            a5 = false;
            a6 = false;
            a7 = false;
            so = false;
            say = 0;
            dur = 0;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            so = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a1 == false)
            {
                Random b1 = new Random();
                label1.Text = b1.Next(0, 10).ToString();
            }
            if (a2 == false)
            {
                Random b2 = new Random();
                label2.Text = b2.Next(0, 10).ToString();
            }
            if (a3 == false)
            {
                Random b3 = new Random();
                label3.Text = b3.Next(0, 10).ToString();
            }
            if (a4 == false)
            {
                Random b4 = new Random();
                label4.Text = b4.Next(0, 10).ToString();
            }
            if (a5 == false)
            {
                Random b5 = new Random();
                label5.Text = b5.Next(0, 10).ToString();
            }
            if (a6 == false)
            {
                Random b6 = new Random();
                label6.Text = b6.Next(0, 10).ToString();
            }
            if (a7 == false)
            {
                Random b7 = new Random();
                label7.Text = b7.Next(0, 10).ToString();
            }
            if (so == true)
            {
                say++;
                if (say == 500)
                {
                    a1 = true;
                }
                if (say == 1000)
                {
                    a2 = true;
                }
                if (say == 1500)
                {
                    a3 = true;
                }
                if (say == 2000)
                {
                    a4 = true;
                }
                if (say == 2500)
                {
                    a5 = true;
                }
                if (say == 3000)
                {
                    a6 = true;
                }
                if (say == 3500)
                {
                    a7 = true;
                }
            }
            if (a7 == true)
            {
                dur++;
                if (dur == 1)
                {
                    MessageBox.Show("Şanslı Numaralar = " + label1.Text + label2.Text + label3.Text + label4.Text + label5.Text + label6.Text + label7.Text);
                }
            }
        }
    }
}
