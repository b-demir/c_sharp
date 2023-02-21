using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gelismis_kronometre_odev_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double salise = 0, saniye = 0, dakika = 0, saat = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "00:00:00:00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;
            label1.Text = "00:00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 60)
            {
                salise = 0;
                saniye++;
                if (saniye == 60)
                {
                    saniye = 0;
                    dakika++;
                    if (dakika == 60)
                    {
                        dakika = 0;
                        saat++;
                    }
                }
            }
            string ssaat = saat.ToString(), sdakika = dakika.ToString(), ssaniye = saniye.ToString(), ssalise = salise.ToString();
            if (saat <= 9)
            {
                ssaat = "0" + saat.ToString();
            }
            if (dakika <= 9)
            {
                sdakika = "0" + dakika.ToString();
            }
            if (saniye <= 9)
            {
                ssaniye = "0" + saniye.ToString();
            }
            if (salise <= 9)
            {
                ssalise = "0" + salise.ToString();
            }
            label1.Text = ssaat + ":" + sdakika + ":" + ssaniye + ":" + ssalise;
        }
    }
}
