namespace C_Sharp_Form_Otobus_Otomasyonu
{
    partial class Otobus_Otomasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otobus_Otomasyon));
            this.grpbkoltuklar = new System.Windows.Forms.GroupBox();
            this.grpMusteri = new System.Windows.Forms.GroupBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.rdoBayan = new System.Windows.Forms.RadioButton();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grpYolculistesi = new System.Windows.Forms.GroupBox();
            this.lstYolculiste = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.grpMusteri.SuspendLayout();
            this.grpYolculistesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbkoltuklar
            // 
            this.grpbkoltuklar.Location = new System.Drawing.Point(54, 41);
            this.grpbkoltuklar.Name = "grpbkoltuklar";
            this.grpbkoltuklar.Size = new System.Drawing.Size(240, 554);
            this.grpbkoltuklar.TabIndex = 0;
            this.grpbkoltuklar.TabStop = false;
            this.grpbkoltuklar.Text = "Koltuklar";
            // 
            // grpMusteri
            // 
            this.grpMusteri.Controls.Add(this.btnIptal);
            this.grpMusteri.Controls.Add(this.btnTamam);
            this.grpMusteri.Controls.Add(this.rdoErkek);
            this.grpMusteri.Controls.Add(this.rdoBayan);
            this.grpMusteri.Controls.Add(this.txtSoyad);
            this.grpMusteri.Controls.Add(this.txtAd);
            this.grpMusteri.Controls.Add(this.lblSoyad);
            this.grpMusteri.Controls.Add(this.lblAd);
            this.grpMusteri.Location = new System.Drawing.Point(385, 41);
            this.grpMusteri.Name = "grpMusteri";
            this.grpMusteri.Size = new System.Drawing.Size(228, 211);
            this.grpMusteri.TabIndex = 1;
            this.grpMusteri.TabStop = false;
            this.grpMusteri.Text = "Müsteri Bilgi";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(123, 181);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(25, 182);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(79, 23);
            this.btnTamam.TabIndex = 6;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Location = new System.Drawing.Point(25, 141);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(53, 17);
            this.rdoErkek.TabIndex = 5;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "Erkek";
            this.rdoErkek.UseVisualStyleBackColor = true;
            this.rdoErkek.CheckedChanged += new System.EventHandler(this.rdoErkek_CheckedChanged);
            // 
            // rdoBayan
            // 
            this.rdoBayan.AutoSize = true;
            this.rdoBayan.Location = new System.Drawing.Point(25, 117);
            this.rdoBayan.Name = "rdoBayan";
            this.rdoBayan.Size = new System.Drawing.Size(55, 17);
            this.rdoBayan.TabIndex = 4;
            this.rdoBayan.TabStop = true;
            this.rdoBayan.Text = "Bayan";
            this.rdoBayan.UseVisualStyleBackColor = true;
            this.rdoBayan.CheckedChanged += new System.EventHandler(this.rdoBayan_CheckedChanged);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(103, 70);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(103, 47);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(22, 73);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(58, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyadınız :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(22, 50);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(41, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Adınız :";
            // 
            // grpYolculistesi
            // 
            this.grpYolculistesi.Controls.Add(this.lstYolculiste);
            this.grpYolculistesi.Location = new System.Drawing.Point(317, 252);
            this.grpYolculistesi.Name = "grpYolculistesi";
            this.grpYolculistesi.Size = new System.Drawing.Size(362, 343);
            this.grpYolculistesi.TabIndex = 1;
            this.grpYolculistesi.TabStop = false;
            this.grpYolculistesi.Text = "Yolcu Listesi";
            // 
            // lstYolculiste
            // 
            this.lstYolculiste.FormattingEnabled = true;
            this.lstYolculiste.Location = new System.Drawing.Point(18, 35);
            this.lstYolculiste.Name = "lstYolculiste";
            this.lstYolculiste.Size = new System.Drawing.Size(327, 290);
            this.lstYolculiste.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(385, 13);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(228, 23);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Yolcu Listesini Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // Otobus_Otomasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 603);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.grpYolculistesi);
            this.Controls.Add(this.grpMusteri);
            this.Controls.Add(this.grpbkoltuklar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Otobus_Otomasyon";
            this.Text = "Yıldırım Otobüs Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpMusteri.ResumeLayout(false);
            this.grpMusteri.PerformLayout();
            this.grpYolculistesi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbkoltuklar;
        private System.Windows.Forms.GroupBox grpMusteri;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.RadioButton rdoErkek;
        private System.Windows.Forms.RadioButton rdoBayan;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.GroupBox grpYolculistesi;
        private System.Windows.Forms.ListBox lstYolculiste;
        private System.Windows.Forms.Button btnGoster;
    }
}

