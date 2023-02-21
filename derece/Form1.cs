using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace derece
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = Convert.ToInt32(label1.Text);
                if (progressBar1.Value <= 0)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\kati.png");
                }
                else if (progressBar1.Value >=100)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\gaz.png");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\sivi.png");
                }
            }
            catch{}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text) + 10).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToInt32(label1.Text) - 10).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\Administrator\\Desktop\\sivi.png");
        }
    }
}
