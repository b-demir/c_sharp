using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int konumx = nesne.Location.X, konumy = nesne.Location.Y, ilk = 0, iki = 0, uc = 0, dort = 0, bes = 0;
            if (e.KeyCode==Keys.W)
            {
                nesne.Location = new System.Drawing.Point(konumx, konumy - 5);
                if (nesne.Location==pictureBox6.Location)
                {
                    ilk += 1;
                    if (ilk==1)
                    {
                        pictureBox17.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox12.Location)
                {
                    iki += 1;
                    if (iki == 1)
                    {
                        pictureBox18.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox28.Location)
                {
                    uc += 1;
                    if (uc == 1)
                    {
                        pictureBox19.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox63.Location)
                {
                    dort += 1;
                    if (dort == 1)
                    {
                        pictureBox20.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox5.Location)
                {
                    bes += 1;
                    if (bes == 1)
                    {
                        pictureBox21.Visible = true;
                    }
                }
            }
            if (e.KeyCode==Keys.S)
            {
                nesne.Location = new System.Drawing.Point(konumx, konumy + 5);
                if (nesne.Location == pictureBox6.Location)
                {
                    ilk += 1;
                    if (ilk == 1)
                    {
                        pictureBox17.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox12.Location)
                {
                    iki += 1;
                    if (iki == 1)
                    {
                        pictureBox18.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox28.Location)
                {
                    uc += 1;
                    if (uc == 1)
                    {
                        pictureBox19.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox63.Location)
                {
                    dort += 1;
                    if (dort == 1)
                    {
                        pictureBox20.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox5.Location)
                {
                    bes += 1;
                    if (bes == 1)
                    {
                        pictureBox21.Visible = true;
                    }
                }
            }
            if (e.KeyCode==Keys.A)
            {
                nesne.Location = new System.Drawing.Point(konumx - 5, konumy);
                if (nesne.Location == pictureBox6.Location)
                {
                    ilk += 1;
                    if (ilk == 1)
                    {
                        pictureBox17.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox12.Location)
                {
                    iki += 1;
                    if (iki == 1)
                    {
                        pictureBox18.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox28.Location)
                {
                    uc += 1;
                    if (uc == 1)
                    {
                        pictureBox19.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox63.Location)
                {
                    dort += 1;
                    if (dort == 1)
                    {
                        pictureBox20.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox5.Location)
                {
                    bes += 1;
                    if (bes == 1)
                    {
                        pictureBox21.Visible = true;
                    }
                }
            }
            if (e.KeyCode==Keys.D)
            {
                nesne.Location = new System.Drawing.Point(konumx + 5, konumy);
                if (nesne.Location == pictureBox6.Location)
                {
                    ilk += 1;
                    if (ilk == 1)
                    {
                        pictureBox17.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox12.Location)
                {
                    iki += 1;
                    if (iki == 1)
                    {
                        pictureBox18.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox28.Location)
                {
                    uc += 1;
                    if (uc == 1)
                    {
                        pictureBox19.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox63.Location)
                {
                    dort += 1;
                    if (dort == 1)
                    {
                        pictureBox20.Visible = true;
                    }
                }
                if (nesne.Location == pictureBox5.Location)
                {
                    bes += 1;
                    if (bes == 1)
                    {
                        pictureBox21.Visible = true;
                    }
                }
            }
        }
    }
}
