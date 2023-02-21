using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text), s2 = Convert.ToInt32(textBox2.Text), toplam = 0;
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            if (s1<=s2)
            {
                for (int i = s1; i <=s2; i++)
                {
                    listBox1.Items.Add(i);
                    toplam += i;
                }
            }
            else
            {
                for (int i = s1; i >= s2; i--)
                {
                    listBox1.Items.Add(i);
                    toplam += i;
                }
            }
            MessageBox.Show("Sayıların Toplamı: " + Convert.ToString(toplam));
        }
    }
}
