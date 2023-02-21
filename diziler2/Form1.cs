using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            isimler[index] = textBox1.Text;
            notlar[index] = int.Parse(textBox2.Text);
            index++;
            textBox2.Text = "";
            textBox1.Text = "";
            if (index == 5)
            {
                index = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < isimler.Length; i++)
            {
                listBox1.Items.Add(isimler[i] + " ==> " + notlar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int enyuksek = 0;
            foreach (int bunot in notlar)
            {
                if (bunot > enyuksek)
                {
                    enyuksek = bunot;
                }
            }
            textBox3.Text = enyuksek.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            int endusuk = 100000000;
            foreach (int bunot in notlar)
            {
                if (bunot < endusuk)
                {
                    endusuk = bunot;
                }
            }
            textBox4.Text = endusuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            int toplam = 0;
            foreach (int bunot in notlar)
            {
                toplam += bunot;
            }
            textBox5.Text = (toplam / notlar.Length).ToString();
        }
    }
}
