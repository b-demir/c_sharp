using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ucgen.a = Convert.ToDouble(textBox1.Text);
            Ucgen.b = Convert.ToDouble(textBox2.Text);
            Ucgen.Alan();
            Ucgen.C();
            Ucgen.Cevre();
            label6.Text = Convert.ToString(Ucgen.alan);
            label7.Text = Convert.ToString(Ucgen.cevre);
            label8.Text = Convert.ToString(Ucgen.c);
        }
    }
    static class Ucgen
    {
        public static double a, b, c, alan, cevre, bos;
        public static void Alan()
        {
            alan = (a * b) / 2;
        }
        public static void C()
        {
            bos = a * a + b * b;
            c=Math.Sqrt(bos);
        }
        public static void Cevre()
        {
            cevre = a + b + c;
        }
    }
}
