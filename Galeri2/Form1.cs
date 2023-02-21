using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a=1;
        bool durum = true;
        public void ileri()
        {
            pictureBox1.Image = Image.FromFile(@"resimler\resim"+(a++)+".png");
            if (a == 9)
            {
                a = 1;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (durum == true)
            {
                durum = false;
                button3.Text = "Slaytı Durdur";
                timer1.Start();
            }
            else if (durum == false)
            {
                durum = true;
                button3.Text = "Slaytı Başlat";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ileri();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a = 1;
            pictureBox1.Image = Image.FromFile(@"resimler\resim"+a+".png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"resimler\resim"+(a--)+".png");
            if (a == 0)
            {
                a = 8;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ileri();
        }
    }
}
