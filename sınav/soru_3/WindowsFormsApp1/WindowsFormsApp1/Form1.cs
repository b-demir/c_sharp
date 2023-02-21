using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_MouseUp(object sender, MouseEventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text), s2 = Convert.ToDouble(textBox2.Text), sonuc;
            sonuc = s1 + s2;
            label1.Text = sonuc.ToString();
        }

        private void radioButton2_MouseUp(object sender, MouseEventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text), s2 = Convert.ToDouble(textBox2.Text), sonuc;
            if (s2>s1)
            {
                textBox1.Text = s2.ToString();
                textBox2.Text = s1.ToString();
            }
            double ys1 = Convert.ToDouble(textBox1.Text), ys2 = Convert.ToDouble(textBox2.Text);
            sonuc = ys1 - ys2;
            label1.Text = sonuc.ToString();
        }

        private void radioButton3_MouseUp(object sender, MouseEventArgs e)
        {
            double s1 = Convert.ToDouble(textBox1.Text), s2 = Convert.ToDouble(textBox2.Text), sonuc;
            sonuc = s1 * s2;
            label1.Text = sonuc.ToString();
        }

        private void radioButton4_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox2.Text!="0")
            {
                double s1 = Convert.ToDouble(textBox1.Text), s2 = Convert.ToDouble(textBox2.Text), sonuc;
                if (s2 > s1)
                {
                    textBox1.Text = s2.ToString();
                    textBox2.Text = s1.ToString();
                }
                double ys1 = Convert.ToDouble(textBox1.Text), ys2 = Convert.ToDouble(textBox2.Text);
                sonuc = ys1 / ys2;
                label1.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Sonuç tanımsız olur.");
            }
        }
    }
}
