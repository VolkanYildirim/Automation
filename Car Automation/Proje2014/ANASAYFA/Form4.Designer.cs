namespace Proje1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniStokKaydıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.yeniStokHareketiGirişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniStokHareketiÇıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stokGezginiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sınıfTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.grupTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diğerİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranıKilitleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(15);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokİşlemleriToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem,
            this.diğerİşlemlerToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(993, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniStokKaydıToolStripMenuItem,
            this.toolStripSeparator1,
            this.yeniStokHareketiGirişToolStripMenuItem,
            this.yeniStokHareketiÇıkışToolStripMenuItem,
            this.toolStripSeparator2,
            this.stokGezginiToolStripMenuItem});
            this.stokİşlemleriToolStripMenuItem.Image = global::Proje2014.Properties.Resources.red_04;
            this.stokİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
            this.stokİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // yeniStokKaydıToolStripMenuItem
            // 
            this.yeniStokKaydıToolStripMenuItem.Image = global::Proje2014.Properties.Resources.green_231;
            this.yeniStokKaydıToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yeniStokKaydıToolStripMenuItem.Name = "yeniStokKaydıToolStripMenuItem";
            this.yeniStokKaydıToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.yeniStokKaydıToolStripMenuItem.Text = "Yeni Araç Kaydı";
            this.yeniStokKaydıToolStripMenuItem.Click += new System.EventHandler(this.yeniStokKaydıToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(262, 6);
            // 
            // yeniStokHareketiGirişToolStripMenuItem
            // 
            this.yeniStokHareketiGirişToolStripMenuItem.Image = global::Proje2014.Properties.Resources.blue_25;
            this.yeniStokHareketiGirişToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yeniStokHareketiGirişToolStripMenuItem.Name = "yeniStokHareketiGirişToolStripMenuItem";
            this.yeniStokHareketiGirişToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.yeniStokHareketiGirişToolStripMenuItem.Text = "Yeni Araç Hareketi(Giriş)";
            this.yeniStokHareketiGirişToolStripMenuItem.Click += new System.EventHandler(this.yeniStokHareketiGirişToolStripMenuItem_Click);
            // 
            // yeniStokHareketiÇıkışToolStripMenuItem
            // 
            this.yeniStokHareketiÇıkışToolStripMenuItem.Image = global::Proje2014.Properties.Resources.yellow_24;
            this.yeniStokHareketiÇıkışToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yeniStokHareketiÇıkışToolStripMenuItem.Name = "yeniStokHareketiÇıkışToolStripMenuItem";
            this.yeniStokHareketiÇıkışToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.yeniStokHareketiÇıkışToolStripMenuItem.Text = "Yeni Araç Hareketi(Çıkış)";
            this.yeniStokHareketiÇıkışToolStripMenuItem.Click += new System.EventHandler(this.yeniStokHareketiÇıkışToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
            // 
            // stokGezginiToolStripMenuItem
            // 
            this.stokGezginiToolStripMenuItem.Image = global::Proje2014.Properties.Resources.red_37;
            this.stokGezginiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stokGezginiToolStripMenuItem.Name = "stokGezginiToolStripMenuItem";
            this.stokGezginiToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.stokGezginiToolStripMenuItem.Text = "Araç Bul";
            this.stokGezginiToolStripMenuItem.Click += new System.EventHandler(this.stokGezginiToolStripMenuItem_Click);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birimTanımlaToolStripMenuItem,
            this.toolStripSeparator3,
            this.sınıfTanımlaToolStripMenuItem,
            this.toolStripSeparator4,
            this.grupTanımlaToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Image = global::Proje2014.Properties.Resources.yellow_23;
            this.tanımlamalarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // birimTanımlaToolStripMenuItem
            // 
            this.birimTanımlaToolStripMenuItem.Image = global::Proje2014.Properties.Resources.red_23;
            this.birimTanımlaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.birimTanımlaToolStripMenuItem.Name = "birimTanımlaToolStripMenuItem";
            this.birimTanımlaToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.birimTanımlaToolStripMenuItem.Text = "Birim Tanımla";
            this.birimTanımlaToolStripMenuItem.Click += new System.EventHandler(this.birimTanımlaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // sınıfTanımlaToolStripMenuItem
            // 
            this.sınıfTanımlaToolStripMenuItem.Image = global::Proje2014.Properties.Resources.blue_23;
            this.sınıfTanımlaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sınıfTanımlaToolStripMenuItem.Name = "sınıfTanımlaToolStripMenuItem";
            this.sınıfTanımlaToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.sınıfTanımlaToolStripMenuItem.Text = "Sınıf Tanımla";
            this.sınıfTanımlaToolStripMenuItem.Click += new System.EventHandler(this.sınıfTanımlaToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // grupTanımlaToolStripMenuItem
            // 
            this.grupTanımlaToolStripMenuItem.Image = global::Proje2014.Properties.Resources.green_23;
            this.grupTanımlaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.grupTanımlaToolStripMenuItem.Name = "grupTanımlaToolStripMenuItem";
            this.grupTanımlaToolStripMenuItem.Size = new System.Drawing.Size(181, 38);
            this.grupTanımlaToolStripMenuItem.Text = "Grup Tanımla";
            this.grupTanımlaToolStripMenuItem.Click += new System.EventHandler(this.grupTanımlaToolStripMenuItem_Click);
            // 
            // diğerİşlemlerToolStripMenuItem
            // 
            this.diğerİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranıKilitleToolStripMenuItem1});
            this.diğerİşlemlerToolStripMenuItem.Image = global::Proje2014.Properties.Resources.blue_03;
            this.diğerİşlemlerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.diğerİşlemlerToolStripMenuItem.Name = "diğerİşlemlerToolStripMenuItem";
            this.diğerİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(149, 36);
            this.diğerİşlemlerToolStripMenuItem.Text = "Diğer İşlemler";
            // 
            // ekranıKilitleToolStripMenuItem1
            // 
            this.ekranıKilitleToolStripMenuItem1.Image = global::Proje2014.Properties.Resources.blue_30;
            this.ekranıKilitleToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ekranıKilitleToolStripMenuItem1.Name = "ekranıKilitleToolStripMenuItem1";
            this.ekranıKilitleToolStripMenuItem1.Size = new System.Drawing.Size(188, 38);
            this.ekranıKilitleToolStripMenuItem1.Text = "Ekranı Kilitle";
            this.ekranıKilitleToolStripMenuItem1.Click += new System.EventHandler(this.ekranıKilitleToolStripMenuItem1_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Image = global::Proje2014.Properties.Resources.red_12;
            this.hakkındaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::Proje2014.Properties.Resources.logout_icon1;
            this.çıkışToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.çıkışToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(86, 36);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(993, 35);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(154, 30);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(50, 2, 2, 2);
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(175, 31);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(230, 30);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(10, 30);
            this.toolStripStatusLabel4.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(230, 30);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 15;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(993, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::Proje2014.Properties.Resources.green_231;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(11, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Kayıt";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::Proje2014.Properties.Resources.blue_25;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(158, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Araç Girişi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.yeniStokHareketiGirişToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = global::Proje2014.Properties.Resources.yellow_241;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(312, 8);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Araç Çıkışı";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.yeniStokHareketiÇıkışToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Image = global::Proje2014.Properties.Resources.blue_30;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(466, 9);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "Ekran Kilidi";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ekranıKilitleToolStripMenuItem1_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Image = global::Proje2014.Properties.Resources.logout_icon;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(618, 9);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button7.Size = new System.Drawing.Size(105, 57);
            this.button7.TabIndex = 6;
            this.button7.Text = "Çıkış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 75);
            this.panel1.TabIndex = 1;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(993, 577);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Honda Yetkili Servis Randevu Kayıt ve Takip Sistemi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniStokKaydıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniStokHareketiGirişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniStokHareketiÇıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokGezginiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınıfTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diğerİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranıKilitleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        protected System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;

    }
}