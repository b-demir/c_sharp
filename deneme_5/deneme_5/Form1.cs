using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            int m1 = pictureBox4.Location.X;
            this.pictureBox4.Location = new System.Drawing.Point(m1-5, 75);
            if (m1 == -1)
            {
                m1 = 730;
                this.pictureBox4.Location = new System.Drawing.Point(m1, 75);
            }
            if (sayac%2 == 0)
            {
                int m2 = pictureBox5.Location.X;
                this.pictureBox5.Location = new System.Drawing.Point(m2 - 5, 175);
                if (m2 == -1)
                {
                    m2 = 730;
                    this.pictureBox5.Location = new System.Drawing.Point(m2, 175);
                }
            }
            if (sayac%3 == 0)
            {
                int m3 = pictureBox6.Location.X;
                this.pictureBox6.Location = new System.Drawing.Point(m3 - 5, 285);
                if (m3 == -1)
                {
                    m3 = 730;
                    this.pictureBox6.Location = new System.Drawing.Point(m3, 285);
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int oyuncux = pictureBox7.Location.X, oyuncuy = pictureBox7.Location.Y;
            if (e.KeyCode == Keys.Space)
            {
                timer1.Start();
            }
            if (e.KeyCode == Keys.A)
            {
                this.pictureBox7.Location = new System.Drawing.Point(oyuncux - 10, oyuncuy);
            }
            if (e.KeyCode == Keys.D)
            {
                this.pictureBox7.Location = new System.Drawing.Point(oyuncux + 10, oyuncuy);
            }
            if (e.KeyCode == Keys.W)
            {
                this.pictureBox7.Location = new System.Drawing.Point(oyuncux, oyuncuy-10);
            }
            if (e.KeyCode == Keys.S)
            {
                this.pictureBox7.Location = new System.Drawing.Point(oyuncux, oyuncuy + 10);
            }
            int m1 = pictureBox4.Location.X, m1y = pictureBox4.Location.Y;
            int m2 = pictureBox5.Location.X, m2y = pictureBox5.Location.Y;
            int m3 = pictureBox6.Location.X, m3y = pictureBox6.Location.Y;
            if (oyuncux == m3 && oyuncuy == m3y)
            {
                timer1.Stop();
                MessageBox.Show("Oyunu Kaybettiniz...");
            }
            if (oyuncux == m2 && oyuncuy == m2y)
            {
                timer1.Stop();
                MessageBox.Show("Oyunu Kaybettiniz...");
            }
            if (oyuncux == m1 && oyuncuy == m1y)
            {
                timer1.Stop();
                MessageBox.Show("Oyunu Kaybettiniz...");
            }
        }
    }
}
