using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asal_sayi_bul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            for (int i = Convert.ToInt32(textBox1.Text); i > 1; i--)
            {
                if (Convert.ToInt32(textBox1.Text) % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 1)
            {
                label2.Text = textBox1.Text + " sayısı asal sayıdır.";
            }
            else
            {
                label2.Text = textBox1.Text + " sayısı asal sayı değildir.";
            }
            textBox1.Text = "";
        }
    }
}
