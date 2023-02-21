using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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
            int sayi1 = Convert.ToInt32(textBox1.Text), sayi2 = Convert.ToInt32(textBox2.Text);
            if (sayi1<=sayi2)
            {
                for (int i = sayi1; i <= sayi2; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
            else
            {
                for (int i = sayi1; i >= sayi2; i--)
                {
                    listBox1.Items.Add(i);
                }
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
