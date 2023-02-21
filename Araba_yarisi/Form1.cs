using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random a1 = new Random();
        string kazanan = "";
        int sayi = 0, sayi2 = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s1 = a1.Next(0, 10);
            int s2 = a1.Next(0, 10);
            pictureBox1.Left += s1;
            pictureBox2.Left += s2;
            if (pictureBox1.Location.X + sayi2 >= pictureBox3.Location.X)
            {
                kazanan = "1.araba";
                timer1.Stop();
            }
            else if (pictureBox2.Location.X + sayi2 >= pictureBox3.Location.X)
            {
                kazanan = "2.araba";
                timer1.Stop();
            }
        }
        int a = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (a == 0)
            {
                pictureBox7.Visible = true;
                a++;
            }
            else if (a == 1)
            {
                pictureBox8.Visible = true;
                a++;
            }
            else if (a == 2)
            {
                pictureBox9.Visible = true;
                timer1.Start();
                timer2.Start();
                timer3.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (kazanan == "1.araba" && sayi == 0)
            {
                sayi++;
                MessageBox.Show("Tebrikler yarışı 1. araba kazandı.");
                timer2.Stop();
            }
            else if (kazanan == "2.araba" && sayi == 0)
            {
                sayi++;
                MessageBox.Show("Tebrikler yarışı 2. araba kazandı.");
                timer2.Stop();
            }
        }
    }
}
