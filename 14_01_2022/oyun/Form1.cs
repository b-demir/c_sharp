using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int x, y;
        int[,] konum = new int[4, 4];
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text), b = Convert.ToInt32(textBox2.Text);
            textBox1.Text = ""; textBox2.Text = "";
            if (konum[a, b] == 1)
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        pictureBox1.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox2.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox3.Image = Image.FromFile("yesilnokta.png");
                    }
                    else
                    {
                        pictureBox4.Image = Image.FromFile("yesilnokta.png");
                    }
                }
                else if (a == 1)
                {
                    if (b == 0)
                    {
                        pictureBox5.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox6.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox7.Image = Image.FromFile("yesilnokta.png");
                    }
                    else
                    {
                        pictureBox8.Image = Image.FromFile("yesilnokta.png");
                    }
                }
                else if (a == 2)
                {
                    if (b == 0)
                    {
                        pictureBox9.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox10.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox11.Image = Image.FromFile("yesilnokta.png");
                    }
                    else
                    {
                        pictureBox12.Image = Image.FromFile("yesilnokta.png");
                    }
                }
                else if (a == 3)
                {
                    if (b == 0)
                    {
                        pictureBox13.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox14.Image = Image.FromFile("yesilnokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox15.Image = Image.FromFile("yesilnokta.png");
                    }
                    else
                    {
                        pictureBox16.Image = Image.FromFile("yesilnokta.png");
                    }
                }
            }
            else
            {
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        pictureBox1.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox2.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox3.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else
                    {
                        pictureBox4.Image = Image.FromFile("kirmizinokta.png");
                    }
                }
                else if (a == 1)
                {
                    if (b == 0)
                    {
                        pictureBox5.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox6.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox7.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else
                    {
                        pictureBox8.Image = Image.FromFile("kirmizinokta.png");
                    }
                }
                else if (a == 2)
                {
                    if (b == 0)
                    {
                        pictureBox9.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox10.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox11.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else
                    {
                        pictureBox12.Image = Image.FromFile("kirmizinokta.png");
                    }
                }
                else if (a == 3)
                {
                    if (b == 0)
                    {
                        pictureBox13.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 1)
                    {
                        pictureBox14.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else if (b == 2)
                    {
                        pictureBox15.Image = Image.FromFile("kirmizinokta.png");
                    }
                    else
                    {
                        pictureBox16.Image = Image.FromFile("kirmizinokta.png");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = rnd.Next(0, 4);
            y = rnd.Next(0, 4);
            konum[x, y] = 1;
        }
    }
}
