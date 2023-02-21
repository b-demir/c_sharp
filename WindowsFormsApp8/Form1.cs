using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yas = DateTime.Now.Year - Convert.ToInt32(textBox1.Text);
            if (yas>=18)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = false;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (checkBox1.Checked==false)
            {
                label2.Text += "Ehliyetiniz olmadığından işe alınmadınız!";
            }
            if (checkBox2.Checked==false)
            {
                label2.Text += "\nKişisel verilerinizin işlenmesine izin vermediğinizden işe alınmadınız!";
            }
            if (radioButton2.Checked==true)
            {
                if (checkBox3.Checked==false)
                {
                    label2.Text += "\nAskerliğinizi yapmadığınızdan işe alınmadınız!";
                }
            }
            if (label2.Text=="")
            {
                MessageBox.Show("Tebrikler işe alındınız.");
            }
        }
    }
}
