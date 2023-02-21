using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuvvet_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= int.Parse(textBox2.Text); i++)
            {
                listBox1.Items.Add(Math.Pow(int.Parse(textBox1.Text),i));
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
