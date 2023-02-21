using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kredi_karti_dogrulama
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
                int toplam = 0;
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = Convert.ToInt32(char.GetNumericValue(textBox1.Text[i]));
                }
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (i%2 == 0)
                    {
                        dizi[i] *= 2;
                        if (dizi[i].ToString().Length == 2)
                        {
                            dizi[i] = (dizi[i] / 10) + (dizi[i] % 10);
                        }
                    }
                    toplam += dizi[i];
                }
                if (toplam % 10 == 0)
                {
                    label1.ForeColor = Color.Lime;
                    label1.Text = "Kredi kartı numarası Doğru!";
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Kredi kartı numarası Yanlış!";
                }
            }
            else if (textBox1.Text.Length > 16)
            {
                label1.ForeColor = Color.Orange;
                label1.Text = "Kredi kartı numarası Fazla!";
            }
            else
            {
                label1.ForeColor = Color.Orange;
                label1.Text = "Kredi kartı numarası Eksik!";
            }
        }
    }
}
