using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
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
            for (int i = 1; i < 100; i++)
            {
                int sayac = 0;
                for (int a = 1; a <= i; a++)
                {
                    if (i%a==0)
                    {
                        sayac++;
                    }
                }
                if (sayac==2)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
