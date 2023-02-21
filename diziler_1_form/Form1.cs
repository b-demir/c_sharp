using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_1_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say = 0;
        string[] isimler = new string[10];
        private void button1_Click(object sender, EventArgs e)
        {
            isimler[say] = textBox1.Text;
            textBox1.Text = "";
            say++;
            if (say == 10)
            {
                foreach(string isim in isimler)
                {
                    listBox1.Items.Add(isim);
                }
                button1.Enabled = false;
            }
        }
    }
}
