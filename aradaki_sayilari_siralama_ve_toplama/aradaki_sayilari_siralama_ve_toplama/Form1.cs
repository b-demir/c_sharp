using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aradaki_sayilari_siralama_ve_toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int s1 = Convert.ToInt32(textBox1.Text), s2 = Convert.ToInt32(textBox2.Text), toplam = 0;
            if (s1<=s2)
            {
                for (int i = s1; i <= s2; i++)
                {
                    toplam += i;
                    listBox1.Items.Add(i);
                }
            }
            else
            {
                for (int i = s1; i >= s2; i--)
                {
                    toplam += i;
                    listBox1.Items.Add(i);
                }
            }
            label2.Text = toplam.ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
