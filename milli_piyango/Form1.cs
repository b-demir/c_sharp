using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milli_piyango
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label1.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label2.Text = sayi.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label3.Text = sayi.ToString();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label4.Text = sayi.ToString();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label5.Text = sayi.ToString();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label6.Text = sayi.ToString();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 9);
            label7.Text = sayi.ToString();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            s++;
            int dur = 0;
            if (s == 1)
            {
                timer1.Stop();
            }
            if (s == 2)
            {
                timer2.Stop();
            }
            if (s == 3)
            {
                timer3.Stop();
            }
            if (s == 4)
            {
                timer4.Stop();
            }
            if (s == 5)
            {
                timer5.Stop();
            }
            if (s == 6)
            {
                timer6.Stop();
            }
            if (s == 7)
            {
                dur++;
                timer7.Stop();
                if (dur == 1)
                {
                    MessageBox.Show("Talihli Numaralar = " + label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text + " " + label5.Text + " " + label6.Text + " " + label7.Text + " ");
                }
                timer8.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer8.Start();
        }
    }
}
