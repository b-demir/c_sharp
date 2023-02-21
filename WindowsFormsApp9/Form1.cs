using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text), sonuc = 1;
            label2.Text = Convert.ToString(sayi) + "! = ";
            for (int i = sayi; i >= 1; i--)
            {
                sonuc *= i;
                if (sayi==1)
                {
                    label2.Text = "1! = 1 = ";
                }
                else if (i==sayi)
                {
                    label2.Text += Convert.ToString(sayi);
                }
                else if (i==1)
                {
                    label2.Text += ".1 = ";
                }
                else
                {
                    label2.Text += "." + Convert.ToString(i);
                }
            }
            label2.Text += Convert.ToString(sonuc);
            textBox1.Text = "";
        }
    }
}
