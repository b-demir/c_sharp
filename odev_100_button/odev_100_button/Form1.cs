using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_100_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly int NOFBUTTON = 100;
        int locx = 0, locy = 0;
        List<Button> m_Buttons = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= NOFBUTTON; i++)
            {
                Button tmp = new Button();
                tmp.Name = "buton" + i.ToString();
                tmp.Text = "BUTTON" + i.ToString();
                tmp.AutoSize = true;
                tmp.Location = new Point(locx, locy);
                locx += tmp.Width;
                tmp.Click += Tmp_Click;
                this.Controls.Add(tmp);
                if (i % 10 == 0)
                {
                    locx = 0;
                    locy += tmp.Height + 10;
                }
            }
        }

        private void Tmp_Click(object sender, EventArgs e)
        {
            Button btnTemp = sender as Button;
            MessageBox.Show(btnTemp.Text + " isimli butona tıkladınız!");
        }
    }
}
