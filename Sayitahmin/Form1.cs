using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayitahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random a = new Random();
        int b, hak = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi == b)
            {
                MessageBox.Show("Tebrikler sayıyı doğru tahmin ettiniz.");
            }
            else
            {
                hak--;
                label1.Text= "Hakkınız = " + hak;
                if (hak == 0)
                {
                    MessageBox.Show("Üzgünüm sayıyı yanlış tahmin ettiniz. Doğru sayı = " + b);
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                }
                else
                {
                    if (b > sayi)
                    {
                        MessageBox.Show("Üzgünüm sayıyı yanlış tahmin ettiniz. Sayıyı arttırın.");
                    }
                    else
                    {
                        MessageBox.Show("Üzgünüm sayıyı yanlış tahmin ettiniz. Sayıyı azaltın.");
                    }
                }
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hak = 3;
            b = a.Next(0, 10);
            textBox1.Enabled = true;
            button1.Enabled = true;
            label1.Text = "Hakkınız = " + hak;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = a.Next(0, 10);
            label1.Text = "Hakkınız = " + hak;
        }
    }
}
