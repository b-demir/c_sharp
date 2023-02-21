using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpimtablosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int secim = Convert.ToInt32(comboBox1.Text);
            for (int i = 0; i <= 10; i++)
            {
                listBox1.Items.Add(secim + "x" + i + "=" + secim * i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                for (int a = 0; a <= 10; a++)
                {
                    listBox1.Items.Add(i + "x" + a + "=" + i * a);
                }
                listBox1.Items.Add("-------------");
            }
        }
    }
}
