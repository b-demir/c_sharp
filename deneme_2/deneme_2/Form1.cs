using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            int konumx = nesne1.Location.X, konumy = nesne1.Location.Y;
            if (e.KeyCode==Keys.W)
            {
                nesne1.Location = new System.Drawing.Point(konumx, konumy - 5);
                if (nesne1.Location.X == 200 && nesne1.Location.Y == 200)
                {
                    MessageBox.Show("Tebrikler doğru yeri buldunuz.");
                }
            }
            else if (e.KeyCode==Keys.S)
            {
                nesne1.Location = new System.Drawing.Point(konumx, konumy + 5);
                if (nesne1.Location.X == 200 && nesne1.Location.Y == 200)
                {
                    MessageBox.Show("Tebrikler doğru yeri buldunuz.");
                }
            }
            else if (e.KeyCode==Keys.A)
            {
                nesne1.Location = new System.Drawing.Point(konumx - 5, konumy);
                if (nesne1.Location.X == 200 && nesne1.Location.Y == 200)
                {
                    MessageBox.Show("Tebrikler doğru yeri buldunuz.");
                }
            }
            else if (e.KeyCode==Keys.D)
            {
                nesne1.Location = new System.Drawing.Point(konumx + 5, konumy);
                if (nesne1.Location.X == 200 && nesne1.Location.Y == 200)
                {
                    MessageBox.Show("Tebrikler doğru yeri buldunuz.");
                }
            }
        }
    }
}
