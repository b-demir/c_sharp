using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        private char islem;
        private double isayi, ssayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void sayi1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void sayi2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void sayi3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void sayi4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void sayi5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void sayi6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void sayi7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void sayi8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void sayi9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void sayi0_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            ssayi = Convert.ToDouble(label1.Text);
            double sonuc;
            switch (islem)
            {
                case '+':
                    sonuc = isayi + ssayi;
                    break;
                case '-':
                    sonuc = isayi - ssayi;
                    break;
                case '/':
                    sonuc = isayi / ssayi;
                    break;
                case '*':
                    sonuc = isayi * ssayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            label2.Text += Convert.ToString(ssayi) + "=";
            label1.Text = Convert.ToString(sonuc);
        }

        private void topla_Click(object sender, EventArgs e)
        {
            islem = '+';
            isayi = Convert.ToDouble(label1.Text);
            label2.Text = Convert.ToString(isayi) + islem;
            label1.Text = "";
        }

        private void cikart_Click(object sender, EventArgs e)
        {
            islem = '-';
            isayi = Convert.ToDouble(label1.Text);
            label2.Text = Convert.ToString(isayi) + islem;
            label1.Text = "";
        }

        private void bol_Click(object sender, EventArgs e)
        {
            islem = '/';
            isayi = Convert.ToDouble(label1.Text);
            label2.Text = Convert.ToString(isayi) + islem;
            label1.Text = "";
        }

        private void carp_Click(object sender, EventArgs e)
        {
            islem = '*';
            isayi = Convert.ToDouble(label1.Text);
            label2.Text = Convert.ToString(isayi) + islem;
            label1.Text = "";
        }

        private void negatif_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void sifirlama_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }
    }
}
