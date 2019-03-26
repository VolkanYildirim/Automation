using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C_Sharp_Form_Otobus_Otomasyonu
{
    public partial class Otobus_Otomasyon : Form
    {
        ArrayList koltuklar = new ArrayList();

        TextBox t = new TextBox();

        Form Form2 = new Form();

        Button BasılanButon;

        string[] yolcular = new string[100];

        string[] koltukcins = new string[100];

        int yolcuSayisi = 0,koltukSayisi=0;

        public Otobus_Otomasyon()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.ControlBox = false;
            rdoErkek.Checked = false;
            rdoBayan.Checked = false;
            t.Location = new Point(40, 40);
            Label l = new Label();
            l.Location = new Point(40,20);
            l.Text = "Koltuk Sayısı :";
            Button b = new Button();
            b.Text = "ÇİZ";
            b.Location = new Point(40,60);
            b.Click+=new EventHandler(b_Click);
            Form2.Controls.Add(t);
            Form2.Controls.Add(l);
            Form2.Controls.Add(b);
            Form2.ShowDialog();
            grpMusteri.Visible = false;
            grpYolculistesi.Visible = false;


            for (int i = 0; i < 40; i++)
            {
                yolcular[i] = "BOŞ";
            }
        }
        void b_Click(object sender, EventArgs e)
        {
           
            string sayi=t.Text;
            bool devam = false;

            for (int i = 0; i < sayi.Length; i++)
		    {
                 if (!char.IsDigit(sayi[i]))
                    devam = true;
		    }

            if (!devam&&sayi.Length!=0)
            {
                if (int.Parse(t.Text) <= 40 &&int.Parse(t.Text)>0)
                {
                    koltukSayisi = int.Parse(t.Text);
                    otobusCiz(koltukSayisi);
                    Form2.Close();
                    for (int i = 0; i < koltukSayisi; i++)
                    {
                       koltukcins[i]=" ";
                    }
                }
                else
                    MessageBox.Show("lütfen 40 veya 40 tan küçük sayi giriniz");
            }
            else
                MessageBox.Show("lütfen 40 veya 40 tan küçük sayi giriniz");
           
            
            t.Text = "";
        }

        void otobusCiz(int koltukSayisi)
        {
            
            int sutun = 0,b=0,satir = 0;;

            for (int i = 0; i < koltukSayisi; i++)
            {
                if (i % 4 == 0 && i != 0)
                {
                    satir++;
                    sutun = 0;
                    b = 0;
                }
                else
                    if (i % 2 == 0 && i!=0)
                        b = 40;
                Button koltuk = new Button();
                koltuk.Name = i.ToString();
                koltuk.TabIndex = i;
                koltuk.TabStop = false;
                koltuk.Text = (i+1).ToString();
                koltuk.Size = new System.Drawing.Size(30, 30);
                Point p = new System.Drawing.Point(30+sutun * koltuk.Width + sutun*10+b, 30+ satir * koltuk.Height*3/2);
                koltuk.Location = p;
                koltuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                koltuk.Visible = true;
                koltuk.BackColor = Color.Gray;
                koltuk.BringToFront();
                koltuk.MouseDown += new MouseEventHandler(this.koltuklarClick);
                grpbkoltuklar.Controls.Add(koltuk);
                this.AutoSize = true;
                koltuklar.Add(koltuk);
                sutun++;
            }

            satir += koltukSayisi / 8;
            grpbkoltuklar.Size = new Size(250, (int)satir * 30+ 100);
        }


        private void koltuklarClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            BasılanButon = (Button)sender;

            grpYolculistesi.Visible = false;
            
            grpMusteri.Visible = true;
            

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            int koltukNo=int.Parse(BasılanButon.Text);
            string cinsiyet = "";


            if (rdoBayan.Checked == true)
            {
                cinsiyet = "Bayan";
                koltukcins[koltukNo] = "B";
            }
            else
                if(rdoErkek.Checked == true)
                {
                    cinsiyet = "Erkek";
                    koltukcins[koltukNo] = "E";
                }



            BasılanButon.BackColor = Color.Red;
            BasılanButon.Enabled = false;
            yolcular[koltukNo-1]=txtAd.Text.PadRight(12,' ')+txtSoyad.Text.PadRight(12,' ')+cinsiyet.PadRight(8,' ');
            yolcuSayisi++;
            grpMusteri.Visible = false;
            txtAd.Text = "";
            txtSoyad.Text = "";
            rdoBayan.Checked = false;
            rdoErkek.Checked = false;
            this.Text = "Yolcu sayisi = " + yolcuSayisi;

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            grpMusteri.Visible = false;
            txtAd.Text = "";
            txtSoyad.Text = "";
            BasılanButon.BackColor = Color.Gray;
            BasılanButon.Enabled = true;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lstYolculiste.Items.Clear();
            grpYolculistesi.Visible = true;
            grpYolculistesi.Location = new Point(350, 40);


            for (int i = 0; i < koltukSayisi; i++)
            {
                lstYolculiste.Items.Add((i+1)+". koltuk:  \t"+yolcular[i]);
            }
        }

        private void rdoBayan_CheckedChanged(object sender, EventArgs e)
        {
            int koltukNo = int.Parse(BasılanButon.Text);


            if (rdoBayan.Checked == true)
            {
                koltukcins[koltukNo] = "B";
            }
            else if (rdoErkek.Checked == true)
            {
                koltukcins[koltukNo] = "E";
            }

            int a = koltukNo;

            if (koltukNo % 4 == 0)
                a--;
            if (koltukNo % 4 == 1)
                a++;
            if (koltukNo % 4 == 2)
                a--;
            if (koltukNo % 4 == 3)
                a++;

            if (koltukcins[a] == "B")
            {
                if (koltukcins[koltukNo] == "E")
                {
                    MessageBox.Show("Bu koltuga sadece bayan biri oturabilir");
                    btnIptal_Click(sender, e);
                }
            }
        }

        private void rdoErkek_CheckedChanged(object sender, EventArgs e)
        {
            rdoBayan_CheckedChanged(sender, e);
        }

    }
}
