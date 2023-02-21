using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucgen_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucgen nesne = new Ucgen();
            nesne.A = Convert.ToDouble(textBox1.Text);
            nesne.B = Convert.ToDouble(textBox2.Text);
            label8.Text = Convert.ToString(nesne.Hipotenus());
            label7.Text = Convert.ToString(nesne.Alan());
            label6.Text = Convert.ToString(nesne.Cevre(Convert.ToDouble(label8.Text)));
        }
    }
    class Ucgen
    {
        public double a, b;
        public double A
        {
            get {return a;}
            set
            {
                if (value <=0)
                {
                    MessageBox.Show("Hatalı bilgi!");
                }
                else
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get {return b;}
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Hatalı bilgi!");
                }
                else
                {
                    b = value;
                }
            }
        }
        public double Hipotenus()
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        public double Alan()
        {
            return (a * b) / 2;
        }
        public double Cevre(double h)
        {
            return a + b + h;
        }
    }
}
