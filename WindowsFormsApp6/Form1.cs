using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char i = 'A'; i <='Z'; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char harf = Convert.ToChar(comboBox1.Text);
            int i = 0;
            switch (harf)
            {
                case 'A':
                    i = 1;
                    break;
                case 'B':
                    i = 2;
                    break;
                case 'C':
                    i = 3;
                    break;
                case 'D':
                    i = 4;
                    break;
                case 'E':
                    i = 5;
                    break;
                case 'F':
                    i = 6;
                    break;
                case 'G':
                    i = 7;
                    break;
                case 'H':
                    i = 8;
                    break;
                case 'I':
                    i = 9;
                    break;
                case 'J':
                    i = 10;
                    break;
                case 'K':
                    i = 11;
                    break;
                case 'L':
                    i = 12;
                    break;
                case 'M':
                    i = 13;
                    break;
                case 'N':
                    i = 14;
                    break;
                case 'O':
                    i = 15;
                    break;
                case 'P':
                    i = 16;
                    break;
                case 'Q':
                    i = 17;
                    break;
                case 'R':
                    i = 18;
                    break;
                case 'S':
                    i = 19;
                    break;
                case 'T':
                    i = 20;
                    break;
                case 'U':
                    i = 21;
                    break;
                case 'V':
                    i = 22;
                    break;
                case 'W':
                    i = 23;
                    break;
                case 'X':
                    i = 24;
                    break;
                case 'Y':
                    i = 25;
                    break;
                case 'Z':
                    i = 26;
                    break;
                default:
                    i = 0;
                    break;
            }
            if (i==0)
            {
                label1.Text = "Lütfen doğru seçin";
            }
            else
            {
                label1.Text = harf + " harfi alfabenin " + Convert.ToString(i) + ". harfidir";
            }
        }
    }
}
