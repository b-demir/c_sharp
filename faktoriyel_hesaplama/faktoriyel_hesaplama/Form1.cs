using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faktoriyel_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int f = 1;
            for (int i = Convert.ToInt32(textBox1.Text); i > 1; i--)
            {
                f *= i;
                label1.Text += i.ToString() + " . ";
            }
            label1.Text += "1 = " + f.ToString();
            textBox1.Text = "";
        }
    }
}
