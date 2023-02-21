using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
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
            int s = Convert.ToInt32(textBox1.Text), sayac = 0;
            for (int i = s-1; i>1; i--)
            {
                if (s%i!=0)
                {
                    sayac += 1;
                }
            }
            if (s==sayac+2)
            {
                label1.Text = Convert.ToString(s) + " sayısı asal sayıdır.";
            }
            else
            {
                label1.Text = Convert.ToString(s) + " sayısı asal sayı değildir.";
            }
            textBox1.Text = "";
        }
    }
}
