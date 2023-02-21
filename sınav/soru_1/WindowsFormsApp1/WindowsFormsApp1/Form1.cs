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
            double ukenar = Convert.ToDouble(textBox1.Text), kkenar = Convert.ToDouble(textBox2.Text), sonuc;
            if (radioButton1.Checked == true)
            {
                sonuc = kkenar * ukenar;
                label4.Text = sonuc.ToString();
            }
        }

        private void radioButton2_MouseUp(object sender, MouseEventArgs e)
        {
            double ukenar = Convert.ToDouble(textBox1.Text), kkenar = Convert.ToDouble(textBox2.Text), sonuc;
            if (radioButton2.Checked == true)
            {
                sonuc = (kkenar + ukenar) * 2;
                label4.Text = sonuc.ToString();
            }
        }
    }
}
