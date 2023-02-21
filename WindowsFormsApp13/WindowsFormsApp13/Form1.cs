using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            for (int i = 0; i <listBox1.Items.Count; i++)
            {
                if (ad == listBox1.Items[i].ToString())
                {
                    MessageBox.Show("Müşteri bulundu!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s, t = listBox1.Items.Count;
            Random rast = new Random();
            s = rast.Next(0, t);
            label1.Text = listBox1.Items[s].ToString();
        }
    }
}
