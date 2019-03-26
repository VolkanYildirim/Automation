namespace Proje1
{
    partial class Form13
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.StokKoduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CinsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BirimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SınıfıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RafNumarasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GözNumarasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AçıklamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TümKayıtlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripDropDownButton1,
            this.toolStripSeparator5,
            this.ToolStripLabel1,
            this.ToolStripTextBox1,
            this.toolStripSeparator4,
            this.ToolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 397);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(914, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // ToolStripDropDownButton1
            // 
            this.ToolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StokKoduToolStripMenuItem,
            this.CinsiToolStripMenuItem,
            this.BirimiToolStripMenuItem,
            this.SınıfıToolStripMenuItem,
            this.GrubuToolStripMenuItem,
            this.RafNumarasıToolStripMenuItem,
            this.GözNumarasıToolStripMenuItem,
            this.AçıklamaToolStripMenuItem,
            this.FiyatToolStripMenuItem,
            this.ToolStripSeparator1,
            this.TümKayıtlarıGösterToolStripMenuItem});
            this.ToolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripDropDownButton1.Image")));
            this.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1";
            this.ToolStripDropDownButton1.Size = new System.Drawing.Size(117, 22);
            this.ToolStripDropDownButton1.Text = "Gelişmiş Arama";
            // 
            // StokKoduToolStripMenuItem
            // 
            this.StokKoduToolStripMenuItem.Checked = true;
            this.StokKoduToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StokKoduToolStripMenuItem.Name = "StokKoduToolStripMenuItem";
            this.StokKoduToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.StokKoduToolStripMenuItem.Text = "Stok Kodu";
            this.StokKoduToolStripMenuItem.Click += new System.EventHandler(this.StokKoduToolStripMenuItem_Click);
            // 
            // CinsiToolStripMenuItem
            // 
            this.CinsiToolStripMenuItem.Name = "CinsiToolStripMenuItem";
            this.CinsiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.CinsiToolStripMenuItem.Text = "Cinsi";
            this.CinsiToolStripMenuItem.Click += new System.EventHandler(this.CinsiToolStripMenuItem_Click);
            // 
            // BirimiToolStripMenuItem
            // 
            this.BirimiToolStripMenuItem.Name = "BirimiToolStripMenuItem";
            this.BirimiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.BirimiToolStripMenuItem.Text = "Birimi";
            this.BirimiToolStripMenuItem.Click += new System.EventHandler(this.BirimiToolStripMenuItem_Click);
            // 
            // SınıfıToolStripMenuItem
            // 
            this.SınıfıToolStripMenuItem.Name = "SınıfıToolStripMenuItem";
            this.SınıfıToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.SınıfıToolStripMenuItem.Text = "Sınıfı";
            this.SınıfıToolStripMenuItem.Click += new System.EventHandler(this.SınıfıToolStripMenuItem_Click);
            // 
            // GrubuToolStripMenuItem
            // 
            this.GrubuToolStripMenuItem.Name = "GrubuToolStripMenuItem";
            this.GrubuToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.GrubuToolStripMenuItem.Text = "Grubu";
            this.GrubuToolStripMenuItem.Click += new System.EventHandler(this.GrubuToolStripMenuItem_Click);
            // 
            // RafNumarasıToolStripMenuItem
            // 
            this.RafNumarasıToolStripMenuItem.Name = "RafNumarasıToolStripMenuItem";
            this.RafNumarasıToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.RafNumarasıToolStripMenuItem.Text = "Raf Numarası";
            this.RafNumarasıToolStripMenuItem.Click += new System.EventHandler(this.RafNumarasıToolStripMenuItem_Click);
            // 
            // GözNumarasıToolStripMenuItem
            // 
            this.GözNumarasıToolStripMenuItem.Name = "GözNumarasıToolStripMenuItem";
            this.GözNumarasıToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.GözNumarasıToolStripMenuItem.Text = "Göz Numarası";
            this.GözNumarasıToolStripMenuItem.Click += new System.EventHandler(this.GözNumarasıToolStripMenuItem_Click);
            // 
            // AçıklamaToolStripMenuItem
            // 
            this.AçıklamaToolStripMenuItem.Name = "AçıklamaToolStripMenuItem";
            this.AçıklamaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AçıklamaToolStripMenuItem.Text = "Açıklama";
            this.AçıklamaToolStripMenuItem.Click += new System.EventHandler(this.AçıklamaToolStripMenuItem_Click);
            // 
            // FiyatToolStripMenuItem
            // 
            this.FiyatToolStripMenuItem.Name = "FiyatToolStripMenuItem";
            this.FiyatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.FiyatToolStripMenuItem.Text = "Fiyat";
            this.FiyatToolStripMenuItem.Click += new System.EventHandler(this.FiyatToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // TümKayıtlarıGösterToolStripMenuItem
            // 
            this.TümKayıtlarıGösterToolStripMenuItem.Name = "TümKayıtlarıGösterToolStripMenuItem";
            this.TümKayıtlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.TümKayıtlarıGösterToolStripMenuItem.Text = "Tüm Kayıtları Göster";
            this.TümKayıtlarıGösterToolStripMenuItem.Click += new System.EventHandler(this.TümKayıtlarıGösterToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(64, 22);
            this.ToolStripLabel1.Text = "Stok Kodu:";
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.BackColor = System.Drawing.Color.Orange;
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToolStripTextBox1.ForeColor = System.Drawing.Color.White;
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(188, 25);
            this.ToolStripTextBox1.Text = "Aranacak Kelimeyi Giriniz...";
            this.ToolStripTextBox1.Enter += new System.EventHandler(this.ToolStripTextBox1_Enter);
            this.ToolStripTextBox1.TextChanged += new System.EventHandler(this.ToolStripTextBox1_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(58, 22);
            this.ToolStripButton2.Text = "Kapat";
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(914, 397);
            this.DataGridView1.TabIndex = 4;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.ContextMenuStrip1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DüzenleToolStripMenuItem,
            this.SilToolStripMenuItem,
            this.ToolStripSeparator2});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(124, 54);
            this.ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // DüzenleToolStripMenuItem
            // 
            this.DüzenleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("DüzenleToolStripMenuItem.Image")));
            this.DüzenleToolStripMenuItem.Name = "DüzenleToolStripMenuItem";
            this.DüzenleToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.DüzenleToolStripMenuItem.Text = "Düzenle";
            this.DüzenleToolStripMenuItem.Click += new System.EventHandler(this.DüzenleToolStripMenuItem_Click);
            // 
            // SilToolStripMenuItem
            // 
            this.SilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SilToolStripMenuItem.Image")));
            this.SilToolStripMenuItem.Name = "SilToolStripMenuItem";
            this.SilToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.SilToolStripMenuItem.Text = "Sil";
            this.SilToolStripMenuItem.Click += new System.EventHandler(this.SilToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stok Kodu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cinsi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birimi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sınıfı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Grubu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Raf No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Göz No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Açıklama";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Birim Fiyat";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Toplam Stok";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 422);
            this.ControlBox = false;
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Gezgini";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStrip2;
        internal System.Windows.Forms.ToolStripDropDownButton ToolStripDropDownButton1;
        internal System.Windows.Forms.ToolStripMenuItem StokKoduToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CinsiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem BirimiToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SınıfıToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GrubuToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RafNumarasıToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem GözNumarasıToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AçıklamaToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem FiyatToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem TümKayıtlarıGösterToolStripMenuItem;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripTextBox ToolStripTextBox1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem DüzenleToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SilToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}