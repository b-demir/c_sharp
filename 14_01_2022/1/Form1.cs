using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[,] notlar = new double[3, 4];
        string[] isimler = new string[3];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            notlar[index, 0] = Convert.ToDouble(textBox2.Text);
            notlar[index, 1] = Convert.ToDouble(textBox3.Text);
            notlar[index, 2] = Convert.ToDouble(textBox4.Text);
            notlar[index, 3] = Convert.ToDouble(textBox5.Text);
            index += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam;
            for (int x = 0; x < 3; x++)
            {
                toplam = 0;
                for (int y = 0; y < 4; y++)
                {
                    toplam += notlar[x, y];
                }
                listBox1.Items.Add(isimler[x] + " ==> " + toplam / 4);
            }
        }
    }
}
