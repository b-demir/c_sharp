using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int ox = oyuncu.Location.X, oy = oyuncu.Location.Y, x1 = mermi1.Location.X, y1 = mermi1.Location.Y, x2 = mermi2.Location.X, y2 = mermi2.Location.Y, x3 = mermi3.Location.X, y3 = mermi3.Location.Y, s = 0;
            if (e.KeyCode == Keys.Space)
            {
                s++;
                if (s == 1)
                {
                    timer1.Start();
                    timer2.Start();
                    timer3.Start();
                }
                else if (s == 2)
                {
                    s = 0;
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                this.oyuncu.Location = new System.Drawing.Point(ox, oy - 5);
            }
            else if (e.KeyCode == Keys.S)
            {
                this.oyuncu.Location = new System.Drawing.Point(ox, oy + 5);
            }
            else if (e.KeyCode == Keys.A)
            {
                this.oyuncu.Location = new System.Drawing.Point(ox - 5, oy);
            }
            else if (e.KeyCode == Keys.D)
            {
                this.oyuncu.Location = new System.Drawing.Point(ox + 5, oy);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ox = oyuncu.Location.X, oy = oyuncu.Location.Y, x1 = mermi1.Location.X, y1 = mermi1.Location.Y;
            this.mermi1.Location = new System.Drawing.Point(x1 - 5, y1);
            if ((ox == x1) && (oy == y1))
            {
                MessageBox.Show("VURULDUNUZ!!!");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int ox = oyuncu.Location.X, oy = oyuncu.Location.Y, x2 = mermi2.Location.X, y2 = mermi2.Location.Y;
            this.mermi2.Location = new System.Drawing.Point(x2 - 5, y2);
            if ((ox == x2) && (oy == y2))
            {
                MessageBox.Show("VURULDUNUZ!!!");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int ox = oyuncu.Location.X, oy = oyuncu.Location.Y, x3 = mermi3.Location.X, y3 = mermi3.Location.Y;
            this.mermi3.Location = new System.Drawing.Point(x3 - 5, y3);
            if ((ox == x3) && (oy == y3))
            {
                MessageBox.Show("VURULDUNUZ!!!");
            }
        }
    }
}
