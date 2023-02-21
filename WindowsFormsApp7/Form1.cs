using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char harf = Convert.ToChar(comboBox1.Text);
            int i;
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
                case 'Ç':
                    i = 4;
                    break;
                case 'D':
                    i = 5;
                    break;
                case 'E':
                    i = 6;
                    break;
                case 'F':
                    i = 7;
                    break;
                case 'G':
                    i = 8;
                    break;
                case 'Ğ':
                    i = 9;
                    break;
                case 'H':
                    i = 10;
                    break;
                case 'I':
                    i = 11;
                    break;
                case 'İ':
                    i = 12;
                    break;
                case 'J':
                    i = 13;
                    break;
                case 'K':
                    i = 14;
                    break;
                case 'L':
                    i = 15;
                    break;
                case 'M':
                    i = 16;
                    break;
                case 'N':
                    i = 17;
                    break;
                case 'O':
                    i = 18;
                    break;
                case 'Ö':
                    i = 19;
                    break;
                case 'P':
                    i = 20;
                    break;
                case 'R':
                    i = 21;
                    break;
                case 'S':
                    i = 22;
                    break;
                case 'Ş':
                    i = 23;
                    break;
                case 'T':
                    i = 24;
                    break;
                case 'U':
                    i = 25;
                    break;
                case 'Ü':
                    i = 26;
                    break;
                case 'V':
                    i = 27;
                    break;
                case 'Y':
                    i = 28;
                    break;
                case 'Z':
                    i = 29;
                    break;
                default:
                    i = 0;
                    break;
            }
            if (i==0)
            {
                label1.Text = "Lütfen Doğru Harf Seçin.";
            }
            else
            {
                label1.Text = "Seçtiğiniz harf: " + Convert.ToString(harf) + " alfabenin " + Convert.ToString(i) + ". harfidir.";
            }
        }
    }
}
