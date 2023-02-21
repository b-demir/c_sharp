using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci.ad = textBox1.Text;
            Ogrenci.soyad = textBox2.Text;
            Ogrenci.ders = textBox3.Text;
            Ogrenci.Yazdir();
            listBox1.Items.Add(Ogrenci.yazdir);
        }
    }
    static class Ogrenci
    {
        public static string ad, soyad, ders, yazdir;
        public static void Yazdir()
        {
            yazdir = String.Format("Öğrencinin Adı: {0}, Soyadı: {1}, Dersi: {2}",ad, soyad, ders);
        }
    }
}
