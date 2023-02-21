using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int locx = 0, locy = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 100; i++)
            {
                int x = rnd.Next(0, 100);
                Button buton = new Button();
                buton.Name = "BUTTON" + i.ToString();
                buton.Text = x.ToString();
                buton.AutoSize = true;
                buton.Location = new Point(locx, locy);
                this.Controls.Add(buton);
                buton.Click += Buton_Click;
                locx += buton.Width + 10;
                if (i % 10 == 0)
                {
                    locy += buton.Height + 10;
                    locx = 0;
                }
            }
        }

        private void Buton_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            tiklanan.Enabled = false;
        }
    }
}
