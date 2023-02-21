
namespace deneme_6
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.atici1 = new System.Windows.Forms.PictureBox();
            this.mermi1 = new System.Windows.Forms.PictureBox();
            this.oyuncu = new System.Windows.Forms.PictureBox();
            this.atici2 = new System.Windows.Forms.PictureBox();
            this.atici3 = new System.Windows.Forms.PictureBox();
            this.mermi2 = new System.Windows.Forms.PictureBox();
            this.mermi3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.atici1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atici2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atici3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi3)).BeginInit();
            this.SuspendLayout();
            // 
            // atici1
            // 
            this.atici1.Image = ((System.Drawing.Image)(resources.GetObject("atici1.Image")));
            this.atici1.Location = new System.Drawing.Point(745, 65);
            this.atici1.Name = "atici1";
            this.atici1.Size = new System.Drawing.Size(44, 67);
            this.atici1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.atici1.TabIndex = 0;
            this.atici1.TabStop = false;
            // 
            // mermi1
            // 
            this.mermi1.Image = ((System.Drawing.Image)(resources.GetObject("mermi1.Image")));
            this.mermi1.Location = new System.Drawing.Point(725, 95);
            this.mermi1.Name = "mermi1";
            this.mermi1.Size = new System.Drawing.Size(18, 10);
            this.mermi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mermi1.TabIndex = 3;
            this.mermi1.TabStop = false;
            // 
            // oyuncu
            // 
            this.oyuncu.Image = ((System.Drawing.Image)(resources.GetObject("oyuncu.Image")));
            this.oyuncu.Location = new System.Drawing.Point(10, 10);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(55, 55);
            this.oyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oyuncu.TabIndex = 6;
            this.oyuncu.TabStop = false;
            // 
            // atici2
            // 
            this.atici2.Image = ((System.Drawing.Image)(resources.GetObject("atici2.Image")));
            this.atici2.Location = new System.Drawing.Point(745, 160);
            this.atici2.Name = "atici2";
            this.atici2.Size = new System.Drawing.Size(44, 67);
            this.atici2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.atici2.TabIndex = 7;
            this.atici2.TabStop = false;
            // 
            // atici3
            // 
            this.atici3.Image = ((System.Drawing.Image)(resources.GetObject("atici3.Image")));
            this.atici3.Location = new System.Drawing.Point(745, 255);
            this.atici3.Name = "atici3";
            this.atici3.Size = new System.Drawing.Size(44, 67);
            this.atici3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.atici3.TabIndex = 8;
            this.atici3.TabStop = false;
            // 
            // mermi2
            // 
            this.mermi2.Image = ((System.Drawing.Image)(resources.GetObject("mermi2.Image")));
            this.mermi2.Location = new System.Drawing.Point(725, 190);
            this.mermi2.Name = "mermi2";
            this.mermi2.Size = new System.Drawing.Size(18, 10);
            this.mermi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mermi2.TabIndex = 9;
            this.mermi2.TabStop = false;
            // 
            // mermi3
            // 
            this.mermi3.Image = ((System.Drawing.Image)(resources.GetObject("mermi3.Image")));
            this.mermi3.Location = new System.Drawing.Point(725, 285);
            this.mermi3.Name = "mermi3";
            this.mermi3.Size = new System.Drawing.Size(18, 10);
            this.mermi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mermi3.TabIndex = 10;
            this.mermi3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 250;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 300;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mermi3);
            this.Controls.Add(this.mermi2);
            this.Controls.Add(this.atici3);
            this.Controls.Add(this.atici2);
            this.Controls.Add(this.oyuncu);
            this.Controls.Add(this.mermi1);
            this.Controls.Add(this.atici1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.atici1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atici2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atici3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mermi3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox atici1;
        private System.Windows.Forms.PictureBox mermi1;
        private System.Windows.Forms.PictureBox oyuncu;
        private System.Windows.Forms.PictureBox atici2;
        private System.Windows.Forms.PictureBox atici3;
        private System.Windows.Forms.PictureBox mermi2;
        private System.Windows.Forms.PictureBox mermi3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

