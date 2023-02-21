using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim1 = "C:\\Users\\Administrator\\Desktop\\resim1.png", resim2 = "C:\\Users\\Administrator\\Desktop\\resim2.png";
        string resim3 = "C:\\Users\\Administrator\\Desktop\\resim3.png", resim4 = "C:\\Users\\Administrator\\Desktop\\resim4.png";
        string resim5 = "C:\\Users\\Administrator\\Desktop\\resim5.png", resim6 = "C:\\Users\\Administrator\\Desktop\\resim6.png";
        string resim7 = "C:\\Users\\Administrator\\Desktop\\resim7.png", resim8 = "C:\\Users\\Administrator\\Desktop\\resim8.png";
        int tutucu;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tutucu == 9)
            {
                tutucu = 1;
            }
            if (tutucu == 1)
            {
                pictureBox1.Image = Image.FromFile(resim1);
                tutucu++;
            }
            else if (tutucu == 2)
            {
                pictureBox1.Image = Image.FromFile(resim2);
                tutucu++;
            }
            else if (tutucu == 3)
            {
                pictureBox1.Image = Image.FromFile(resim3);
                tutucu++;
            }
            else if (tutucu == 4)
            {
                pictureBox1.Image = Image.FromFile(resim4);
                tutucu++;
            }
            else if (tutucu == 5)
            {
                pictureBox1.Image = Image.FromFile(resim5);
                tutucu++;
            }
            else if (tutucu == 6)
            {
                pictureBox1.Image = Image.FromFile(resim6);
                tutucu++;
            }
            else if (tutucu == 7)
            {
                pictureBox1.Image = Image.FromFile(resim7);
                tutucu++;
            }
            else if (tutucu == 8)
            {
                pictureBox1.Image = Image.FromFile(resim8);
                tutucu++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tutucu = 1;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tutucu--;
            if (tutucu == 0)
            {
                tutucu = 8;
            }
            if (tutucu == 9)
            {
                tutucu = 1;
            }
            if (tutucu == 1)
            {
                pictureBox1.Image = Image.FromFile(resim1);
            }
            else if (tutucu == 2)
            {
                pictureBox1.Image = Image.FromFile(resim2);
            }
            else if (tutucu == 3)
            {
                pictureBox1.Image = Image.FromFile(resim3);
            }
            else if (tutucu == 4)
            {
                pictureBox1.Image = Image.FromFile(resim4);
            }
            else if (tutucu == 5)
            {
                pictureBox1.Image = Image.FromFile(resim5);
            }
            else if (tutucu == 6)
            {
                pictureBox1.Image = Image.FromFile(resim6);
            }
            else if (tutucu == 7)
            {
                pictureBox1.Image = Image.FromFile(resim7);
            }
            else if (tutucu == 8)
            {
                pictureBox1.Image = Image.FromFile(resim8);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tutucu++;
            if (tutucu == 9)
            {
                tutucu = 1;
            }
            if (tutucu == 1)
            {
                pictureBox1.Image = Image.FromFile(resim1);
            }
            else if (tutucu == 2)
            {
                pictureBox1.Image = Image.FromFile(resim2);
            }
            else if (tutucu == 3)
            {
                pictureBox1.Image = Image.FromFile(resim3);
            }
            else if (tutucu == 4)
            {
                pictureBox1.Image = Image.FromFile(resim4);
            }
            else if (tutucu == 5)
            {
                pictureBox1.Image = Image.FromFile(resim5);
            }
            else if (tutucu == 6)
            {
                pictureBox1.Image = Image.FromFile(resim6);
            }
            else if (tutucu == 7)
            {
                pictureBox1.Image = Image.FromFile(resim7);
            }
            else if (tutucu == 8)
            {
                pictureBox1.Image = Image.FromFile(resim8);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\resim1.png");
            tutucu = 1;
        }
    }
}
