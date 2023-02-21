using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gelismis_kronometre_odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0, salise = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString() + ":" + salise.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saat = 0;
            dakika = 0;
            saniye = 0;
            salise = 0;
            label1.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString() + ":" + salise.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise==60)
            {
                salise = 0;
                saniye++;
                if (saniye==60)
                {
                    saniye = 0;
                    dakika++;
                    if (dakika==60)
                    {
                        dakika = 0;
                        saat++;
                    }
                }
            }
            label1.Text = saat.ToString() + ":" + dakika.ToString() + ":" + saniye.ToString() + ":" + salise.ToString();
        }
    }
}
