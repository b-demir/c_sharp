using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_basvurusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year-100; i--)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Year-Convert.ToInt32(comboBox1.Text)>=18)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label2.Text = "";
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                checkBox3.Checked = false;
                checkBox3.Visible = false;
                checkBox1.Checked = false;
                checkBox1.Visible = false;
                checkBox2.Checked = false;
                checkBox2.Visible = false;
                label2.Visible = true;
                button2.Visible = false;
                label2.Text = "Yaşınız 18'den küçük olduğu için iş başvurusu yapamazsınız.";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            button2.Visible = true;
            if (radioButton2.Checked)
            {
                checkBox3.Visible = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "";
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            button2.Visible = true;
            if (radioButton1.Checked)
            {
                checkBox3.Visible = false;
            }
        }
        string kabul = "Tebrikler işe alındınız.", ret = "Hiçbir koşulu karşılamadığınız için işe alınmadınız.", r3 = "Askerliğinizi yapmadığınız için işe alınmadınız.",
            r2 = "Kişisel verilerinizin işlenmesini onaylamadığınız için işe alınmadınız.", r1 = "Ehliyetiniz olmadığı için işe alınmadınız.",
            r12 = "Kişisel verilerinizin işlenmesini onaylamadığınız ve \nehliyetiniz olmadığı için işe alınmadınız.",
            r13 = "Askerliğinizi yapmadığınız ve \nehliyetiniz olmadığı için işe alınmadınız.",
            r23 = "Kişisel verilerinizin işlenmesini onaylamadığınız ve \naskerliğinizi yapmadığınız için işe alınmadınız.";

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (radioButton2.Checked)
            {
                if (checkBox1.Checked & checkBox2.Checked & checkBox3.Checked)
                {
                    label2.Text = kabul;
                }
                else
                {
                    if (checkBox1.Checked & checkBox2.Checked)
                    {
                        label2.Text = r3;
                    }
                    else if (checkBox1.Checked & checkBox3.Checked)
                    {
                        label2.Text = r2;
                    }
                    else if (checkBox1.Checked)
                    {
                        label2.Text = r23;
                    }
                    else if (checkBox2.Checked & checkBox3.Checked)
                    {
                        label2.Text = r1;
                    }
                    else if (checkBox2.Checked)
                    {
                        label2.Text = r13;
                    }
                    else if (checkBox3.Checked)
                    {
                        label2.Text = r12;
                    }
                    else
                    {
                        label2.Text = ret;
                    }
                }
            }
            else
            {
                if (checkBox1.Checked & checkBox2.Checked)
                {
                    label2.Text = kabul;
                }
                else if (checkBox1.Checked)
                {
                    label2.Text = r2;
                }
                else if (checkBox2.Checked)
                {
                    label2.Text = r1;
                }
                else
                {
                    label2.Text = ret;
                }
            }
        }
    }
}
