
namespace hesap_makinesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sayi1 = new System.Windows.Forms.Button();
            this.sayi2 = new System.Windows.Forms.Button();
            this.topla = new System.Windows.Forms.Button();
            this.sayi3 = new System.Windows.Forms.Button();
            this.cikart = new System.Windows.Forms.Button();
            this.sayi6 = new System.Windows.Forms.Button();
            this.sayi5 = new System.Windows.Forms.Button();
            this.sayi4 = new System.Windows.Forms.Button();
            this.carp = new System.Windows.Forms.Button();
            this.sifirlama = new System.Windows.Forms.Button();
            this.sayi0 = new System.Windows.Forms.Button();
            this.bol = new System.Windows.Forms.Button();
            this.sayi9 = new System.Windows.Forms.Button();
            this.sayi8 = new System.Windows.Forms.Button();
            this.sayi7 = new System.Windows.Forms.Button();
            this.esittir = new System.Windows.Forms.Button();
            this.negatif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 98);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(262, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 25);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sayi1
            // 
            this.sayi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi1.Location = new System.Drawing.Point(104, 110);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(75, 65);
            this.sayi1.TabIndex = 2;
            this.sayi1.Text = "1";
            this.sayi1.UseVisualStyleBackColor = false;
            this.sayi1.Click += new System.EventHandler(this.sayi1_Click);
            // 
            // sayi2
            // 
            this.sayi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi2.Location = new System.Drawing.Point(185, 110);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(75, 65);
            this.sayi2.TabIndex = 3;
            this.sayi2.Text = "2";
            this.sayi2.UseVisualStyleBackColor = false;
            this.sayi2.Click += new System.EventHandler(this.sayi2_Click);
            // 
            // topla
            // 
            this.topla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.topla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.topla.Location = new System.Drawing.Point(347, 110);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(75, 65);
            this.topla.TabIndex = 5;
            this.topla.Text = "+";
            this.topla.UseVisualStyleBackColor = false;
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // sayi3
            // 
            this.sayi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi3.Location = new System.Drawing.Point(266, 110);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(75, 65);
            this.sayi3.TabIndex = 4;
            this.sayi3.Text = "3";
            this.sayi3.UseVisualStyleBackColor = false;
            this.sayi3.Click += new System.EventHandler(this.sayi3_Click);
            // 
            // cikart
            // 
            this.cikart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cikart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikart.Location = new System.Drawing.Point(347, 202);
            this.cikart.Name = "cikart";
            this.cikart.Size = new System.Drawing.Size(75, 65);
            this.cikart.TabIndex = 9;
            this.cikart.Text = "-";
            this.cikart.UseVisualStyleBackColor = false;
            this.cikart.Click += new System.EventHandler(this.cikart_Click);
            // 
            // sayi6
            // 
            this.sayi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi6.Location = new System.Drawing.Point(266, 202);
            this.sayi6.Name = "sayi6";
            this.sayi6.Size = new System.Drawing.Size(75, 65);
            this.sayi6.TabIndex = 8;
            this.sayi6.Text = "6";
            this.sayi6.UseVisualStyleBackColor = false;
            this.sayi6.Click += new System.EventHandler(this.sayi6_Click);
            // 
            // sayi5
            // 
            this.sayi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi5.Location = new System.Drawing.Point(185, 202);
            this.sayi5.Name = "sayi5";
            this.sayi5.Size = new System.Drawing.Size(75, 65);
            this.sayi5.TabIndex = 7;
            this.sayi5.Text = "5";
            this.sayi5.UseVisualStyleBackColor = false;
            this.sayi5.Click += new System.EventHandler(this.sayi5_Click);
            // 
            // sayi4
            // 
            this.sayi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi4.Location = new System.Drawing.Point(104, 202);
            this.sayi4.Name = "sayi4";
            this.sayi4.Size = new System.Drawing.Size(75, 65);
            this.sayi4.TabIndex = 6;
            this.sayi4.Text = "4";
            this.sayi4.UseVisualStyleBackColor = false;
            this.sayi4.Click += new System.EventHandler(this.sayi4_Click);
            // 
            // carp
            // 
            this.carp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carp.Location = new System.Drawing.Point(347, 383);
            this.carp.Name = "carp";
            this.carp.Size = new System.Drawing.Size(75, 65);
            this.carp.TabIndex = 17;
            this.carp.Text = "X";
            this.carp.UseVisualStyleBackColor = false;
            this.carp.Click += new System.EventHandler(this.carp_Click);
            // 
            // sifirlama
            // 
            this.sifirlama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sifirlama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifirlama.Location = new System.Drawing.Point(266, 383);
            this.sifirlama.Name = "sifirlama";
            this.sifirlama.Size = new System.Drawing.Size(75, 65);
            this.sifirlama.TabIndex = 16;
            this.sifirlama.Text = "C";
            this.sifirlama.UseVisualStyleBackColor = false;
            this.sifirlama.Click += new System.EventHandler(this.sifirlama_Click);
            // 
            // sayi0
            // 
            this.sayi0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi0.Location = new System.Drawing.Point(185, 383);
            this.sayi0.Name = "sayi0";
            this.sayi0.Size = new System.Drawing.Size(75, 65);
            this.sayi0.TabIndex = 15;
            this.sayi0.Text = "0";
            this.sayi0.UseVisualStyleBackColor = false;
            this.sayi0.Click += new System.EventHandler(this.sayi0_Click);
            // 
            // bol
            // 
            this.bol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bol.Location = new System.Drawing.Point(347, 291);
            this.bol.Name = "bol";
            this.bol.Size = new System.Drawing.Size(75, 65);
            this.bol.TabIndex = 13;
            this.bol.Text = "÷";
            this.bol.UseVisualStyleBackColor = false;
            this.bol.Click += new System.EventHandler(this.bol_Click);
            // 
            // sayi9
            // 
            this.sayi9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi9.Location = new System.Drawing.Point(266, 291);
            this.sayi9.Name = "sayi9";
            this.sayi9.Size = new System.Drawing.Size(75, 65);
            this.sayi9.TabIndex = 12;
            this.sayi9.Text = "9";
            this.sayi9.UseVisualStyleBackColor = false;
            this.sayi9.Click += new System.EventHandler(this.sayi9_Click);
            // 
            // sayi8
            // 
            this.sayi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi8.Location = new System.Drawing.Point(185, 291);
            this.sayi8.Name = "sayi8";
            this.sayi8.Size = new System.Drawing.Size(75, 65);
            this.sayi8.TabIndex = 11;
            this.sayi8.Text = "8";
            this.sayi8.UseVisualStyleBackColor = false;
            this.sayi8.Click += new System.EventHandler(this.sayi8_Click);
            // 
            // sayi7
            // 
            this.sayi7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.sayi7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayi7.Location = new System.Drawing.Point(104, 291);
            this.sayi7.Name = "sayi7";
            this.sayi7.Size = new System.Drawing.Size(75, 65);
            this.sayi7.TabIndex = 10;
            this.sayi7.Text = "7";
            this.sayi7.UseVisualStyleBackColor = false;
            this.sayi7.Click += new System.EventHandler(this.sayi7_Click);
            // 
            // esittir
            // 
            this.esittir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittir.Location = new System.Drawing.Point(104, 383);
            this.esittir.Name = "esittir";
            this.esittir.Size = new System.Drawing.Size(75, 65);
            this.esittir.TabIndex = 18;
            this.esittir.Text = "=";
            this.esittir.UseVisualStyleBackColor = false;
            this.esittir.Click += new System.EventHandler(this.esittir_Click);
            // 
            // negatif
            // 
            this.negatif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.negatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.negatif.Location = new System.Drawing.Point(428, 110);
            this.negatif.Name = "negatif";
            this.negatif.Size = new System.Drawing.Size(94, 338);
            this.negatif.TabIndex = 19;
            this.negatif.Text = "negatif";
            this.negatif.UseVisualStyleBackColor = false;
            this.negatif.Click += new System.EventHandler(this.negatif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 531);
            this.Controls.Add(this.negatif);
            this.Controls.Add(this.esittir);
            this.Controls.Add(this.carp);
            this.Controls.Add(this.sifirlama);
            this.Controls.Add(this.sayi0);
            this.Controls.Add(this.bol);
            this.Controls.Add(this.sayi9);
            this.Controls.Add(this.sayi8);
            this.Controls.Add(this.sayi7);
            this.Controls.Add(this.cikart);
            this.Controls.Add(this.sayi6);
            this.Controls.Add(this.sayi5);
            this.Controls.Add(this.sayi4);
            this.Controls.Add(this.topla);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sayi1;
        private System.Windows.Forms.Button sayi2;
        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.Button sayi3;
        private System.Windows.Forms.Button cikart;
        private System.Windows.Forms.Button sayi6;
        private System.Windows.Forms.Button sayi5;
        private System.Windows.Forms.Button sayi4;
        private System.Windows.Forms.Button carp;
        private System.Windows.Forms.Button sifirlama;
        private System.Windows.Forms.Button sayi0;
        private System.Windows.Forms.Button bol;
        private System.Windows.Forms.Button sayi9;
        private System.Windows.Forms.Button sayi8;
        private System.Windows.Forms.Button sayi7;
        private System.Windows.Forms.Button esittir;
        private System.Windows.Forms.Button negatif;
    }
}

