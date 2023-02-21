using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisal_loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[6] { 0, 0, 0, 0, 0, 0 };
            int i = 0;
            label7.Text = "";
            while (true)
            {
                int sayi = rnd.Next(1, 50);
                if (Array.IndexOf(dizi,sayi)==-1)
                {
                    dizi[i] = sayi;
                    i++;
                }
                if (i == dizi.Length)
                {
                    break;
                }
            }
            Array.Sort(dizi);
            label7.Text = dizi[0].ToString();
            for (int a = 1; a < dizi.Length; a++)
            {
                label7.Text += " " + dizi[a].ToString();
            }
        }
    }
}
