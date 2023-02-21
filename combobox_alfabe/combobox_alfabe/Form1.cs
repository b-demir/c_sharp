using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_alfabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] dizi = new char[29] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(char i in dizi)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            char harf = Convert.ToChar(comboBox1.Text);
            int a;
            switch (harf)
            {
                case 'A':
                    a = 1;
                    break;
                case 'B':
                    a = 2;
                    break;
                case 'C':
                    a = 3;
                    break;
                case 'Ç':
                    a = 4;
                    break;
                case 'D':
                    a = 5;
                    break;
                case 'E':
                    a = 6;
                    break;
                case 'F':
                    a = 7;
                    break;
                case 'G':
                    a = 8;
                    break;
                case 'Ğ':
                    a = 9;
                    break;
                case 'H':
                    a = 10;
                    break;
                case 'I':
                    a = 11;
                    break;
                case 'İ':
                    a = 12;
                    break;
                case 'J':
                    a = 13;
                    break;
                case 'K':
                    a = 14;
                    break;
                case 'L':
                    a = 15;
                    break;
                case 'M':
                    a = 16;
                    break;
                case 'N':
                    a = 17;
                    break;
                case 'O':
                    a = 18;
                    break;
                case 'Ö':
                    a = 19;
                    break;
                case 'P':
                    a = 20;
                    break;
                case 'R':
                    a = 21;
                    break;
                case 'S':
                    a = 22;
                    break;
                case 'Ş':
                    a = 23;
                    break;
                case 'T':
                    a = 24;
                    break;
                case 'U':
                    a = 25;
                    break;
                case 'Ü':
                    a = 26;
                    break;
                case 'V':
                    a = 27;
                    break;
                case 'Y':
                    a = 28;
                    break;
                case 'Z':
                    a = 29;
                    break;
                default:
                    a = 0;
                    break;
            }
            switch (a)
            {
                case 0:
                    label1.Text = "Lütfen doğru seçimi yapınız!";
                    break;
                default:
                    label1.Text = harf + " harfi alfabenin " + a.ToString() + " . harfidir.";
                    break;
            }
        }
    }
}
