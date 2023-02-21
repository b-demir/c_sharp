using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kredi_kartı_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 16)
            {
                int[] dizi = new int[16];
                int ttoplam = 0, ctoplam = 0, cttoplam = 0;
                int sayi, ksayi;
                string no = textBox1.Text;
                if (no.Length == 16)
                {
                    for (int i = 0; i <= dizi.Length - 1; i++)
                    {
                        dizi[i] = Convert.ToInt32((no[i]).ToString());
                    }
                    for (int i = 1; i < dizi.Length; i += 2)
                    {
                        ttoplam += dizi[i];
                    }
                    for (int i = 0; i < dizi.Length; i += 2)
                    {
                        sayi = (dizi[i]) * 2;
                        if (sayi > 9)
                        {
                            ksayi = sayi / 10;
                            sayi = ksayi + (sayi % 10);
                        }
                        ctoplam += sayi;
                    }
                    cttoplam = ctoplam + ttoplam;
                    if (cttoplam % 10 == 0)
                    {
                        label1.ForeColor = Color.Green;
                        label1.Text = "Kredi kartı numarası doğru!";
                    }
                    else
                    {
                        label1.ForeColor = Color.Red;
                        label1.Text = "Kredi kartı numarası yanlış!";
                    }
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Kredi kartı numarası yanlış!";
                }
            }
            else
            {
                label1.ForeColor = Color.Yellow;
                label1.Text = "Kredi kartı numarası eksik!";
            }
        }
    }
}
