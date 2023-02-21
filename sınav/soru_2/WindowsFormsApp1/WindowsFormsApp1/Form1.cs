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
            listBox1.Items.Clear();
            int s1 = Convert.ToInt32(textBox1.Text), s2 = Convert.ToInt32(textBox2.Text);
            if (s1<=s2)
            {
                for (int i = s1; i <= s2; i++)
                {
                    if (i % 2 != 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                for (int i = s1; i >= s2; i--)
                {
                    if (i % 2 != 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
        }

        private void radioButton2_MouseUp(object sender, MouseEventArgs e)
        {
            listBox1.Items.Clear();
            int s1 = Convert.ToInt32(textBox1.Text), s2 = Convert.ToInt32(textBox2.Text);
            if (s1 <= s2)
            {
                for (int i = s1; i <= s2; i++)
                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            else
            {
                for (int i = s1; i >= s2; i--)
                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
        }
    }
}
