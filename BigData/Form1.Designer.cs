namespace BigData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.ptbYeniKayitEkle = new System.Windows.Forms.PictureBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKisiListesi = new System.Windows.Forms.ComboBox();
            this.ptbKayitGoruntuleme = new System.Windows.Forms.PictureBox();
            this.txtTelKayitGoruntuleme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEpostaKayitGoruntuleme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoyisimKayitGoruntuleme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIsimKayitGoruntuleme = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYeniKayitEkle)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKayitGoruntuleme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnResimEkle);
            this.groupBox1.Controls.Add(this.ptbYeniKayitEkle);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt Ekle";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(93, 200);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(248, 200);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(114, 23);
            this.btnResimEkle.TabIndex = 9;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // ptbYeniKayitEkle
            // 
            this.ptbYeniKayitEkle.Location = new System.Drawing.Point(248, 65);
            this.ptbYeniKayitEkle.Name = "ptbYeniKayitEkle";
            this.ptbYeniKayitEkle.Size = new System.Drawing.Size(114, 113);
            this.ptbYeniKayitEkle.TabIndex = 8;
            this.ptbYeniKayitEkle.TabStop = false;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(93, 155);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 22);
            this.txtTel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tel";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(93, 125);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(121, 22);
            this.txtEposta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Eposta";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(93, 95);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(121, 22);
            this.txtSoyisim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyisim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(93, 65);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(121, 22);
            this.txtIsim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKisiListesi);
            this.groupBox2.Controls.Add(this.ptbKayitGoruntuleme);
            this.groupBox2.Controls.Add(this.txtTelKayitGoruntuleme);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEpostaKayitGoruntuleme);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSoyisimKayitGoruntuleme);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIsimKayitGoruntuleme);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(464, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 291);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıt Görüntüle";
            // 
            // cmbKisiListesi
            // 
            this.cmbKisiListesi.FormattingEnabled = true;
            this.cmbKisiListesi.Location = new System.Drawing.Point(19, 21);
            this.cmbKisiListesi.Name = "cmbKisiListesi";
            this.cmbKisiListesi.Size = new System.Drawing.Size(335, 24);
            this.cmbKisiListesi.TabIndex = 20;
            this.cmbKisiListesi.SelectedIndexChanged += new System.EventHandler(this.cmbKisiListesi_SelectedIndexChanged);
            // 
            // ptbKayitGoruntuleme
            // 
            this.ptbKayitGoruntuleme.Location = new System.Drawing.Point(240, 68);
            this.ptbKayitGoruntuleme.Name = "ptbKayitGoruntuleme";
            this.ptbKayitGoruntuleme.Size = new System.Drawing.Size(114, 113);
            this.ptbKayitGoruntuleme.TabIndex = 19;
            this.ptbKayitGoruntuleme.TabStop = false;
            // 
            // txtTelKayitGoruntuleme
            // 
            this.txtTelKayitGoruntuleme.Location = new System.Drawing.Point(85, 158);
            this.txtTelKayitGoruntuleme.Name = "txtTelKayitGoruntuleme";
            this.txtTelKayitGoruntuleme.Size = new System.Drawing.Size(121, 22);
            this.txtTelKayitGoruntuleme.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tel";
            // 
            // txtEpostaKayitGoruntuleme
            // 
            this.txtEpostaKayitGoruntuleme.Location = new System.Drawing.Point(85, 128);
            this.txtEpostaKayitGoruntuleme.Name = "txtEpostaKayitGoruntuleme";
            this.txtEpostaKayitGoruntuleme.Size = new System.Drawing.Size(121, 22);
            this.txtEpostaKayitGoruntuleme.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Eposta";
            // 
            // txtSoyisimKayitGoruntuleme
            // 
            this.txtSoyisimKayitGoruntuleme.Location = new System.Drawing.Point(85, 98);
            this.txtSoyisimKayitGoruntuleme.Name = "txtSoyisimKayitGoruntuleme";
            this.txtSoyisimKayitGoruntuleme.Size = new System.Drawing.Size(121, 22);
            this.txtSoyisimKayitGoruntuleme.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Soyisim";
            // 
            // txtIsimKayitGoruntuleme
            // 
            this.txtIsimKayitGoruntuleme.Location = new System.Drawing.Point(85, 68);
            this.txtIsimKayitGoruntuleme.Name = "txtIsimKayitGoruntuleme";
            this.txtIsimKayitGoruntuleme.Size = new System.Drawing.Size(121, 22);
            this.txtIsimKayitGoruntuleme.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "İsim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYeniKayitEkle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbKayitGoruntuleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox ptbYeniKayitEkle;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKisiListesi;
        private System.Windows.Forms.PictureBox ptbKayitGoruntuleme;
        private System.Windows.Forms.TextBox txtTelKayitGoruntuleme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEpostaKayitGoruntuleme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoyisimKayitGoruntuleme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIsimKayitGoruntuleme;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

