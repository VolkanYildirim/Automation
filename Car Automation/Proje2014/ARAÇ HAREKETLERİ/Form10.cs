using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
namespace Proje1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        bool yeni;
        OleDbConnection bag;
        public void baglanti() {
            bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ARAC.mdb");
            bag.Open();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
        if(yeni==false){

           DialogResult m = MessageBox.Show("Yeni Kayıt modundasınız. Girdiğiniz veriler silinecek.\nÇıkmak istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(m==DialogResult.Yes)
                this.Close();
            else
                return;
        }else{
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                    c.Text="";
            }

            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "0";
            TextBox6.Text = "0";
            TextBox7.Text = "0";
            TextBox8.Text = "0";
            TextBox9.Text = "0";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox14.Text = "";

            DateTimePicker1.Enabled = false;
            TextBox14.Enabled = false;
            ComboBox2.Enabled = false;
            Button2.Enabled = true;
            Button3.Enabled = false;
            Button4.Enabled = false;
            TextBox3.Enabled = false;
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;

            ComboBox2.SelectedIndex = -1;
            this.Close();
        }


        yeni = true;   
        foreach(Control c in this.Controls)
        {
            if(c is TextBox)
                c.Text="";
        }
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "0";
        TextBox6.Text = "0";
        TextBox7.Text = "0";
        TextBox8.Text = "0";
        TextBox9.Text = "0";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox14.Text = "";

        DateTimePicker1.Enabled = false;
        TextBox14.Enabled = false;
        ComboBox2.Enabled = false;
        Button2.Enabled = true;
        Button3.Enabled = false;
        Button4.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        TextBox6.Enabled = false;
        TextBox7.Enabled = false;
        TextBox8.Enabled = false;
        TextBox9.Enabled = false;
        TextBox10.Enabled = false;
        TextBox11.Enabled = false;
        TextBox12.Enabled = false;

        ComboBox2.SelectedIndex = -1;
        this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        yeni = true;
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "0";
        TextBox7.Text = "0";
        TextBox8.Text = "0";
        TextBox9.Text = "0";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox14.Text = "";

        DateTimePicker1.Enabled = true;
        TextBox14.Enabled = true;
        ComboBox2.Enabled = true;
        Button2.Enabled = false;
        Button3.Enabled = true;
        Button4.Enabled = true;
        TextBox3.Enabled = true;
        TextBox4.Enabled = true;
        TextBox5.Enabled = true;
        TextBox6.Enabled = true;
        TextBox7.Enabled = true;
        TextBox8.Enabled = true;
        TextBox9.Enabled = true;
        TextBox10.Enabled = true;
        TextBox11.Enabled = true;
        TextBox12.Enabled = true;

        ComboBox2.SelectedIndex = -1;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            yeni = false;
            Form11 frm11 =new Form11();
            frm11.gelen = true;
            frm11.ShowDialog();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
        yeni = false;
        Timer1.Enabled = true;
        Label16.Text = DateTime.Now.ToLongDateString();
        DateTimePicker1.Text = "";
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "0";
        TextBox7.Text = "0";
        TextBox8.Text = "0";
        TextBox9.Text = "0";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox14.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Label17.Text = DateTime.Now.ToLongTimeString();
        }

        public void hesapla()
        {
            if (TextBox5.Text != "" && TextBox7.Text != "" && TextBox8.Text != "" && TextBox9.Text != "")
            {
                double a = 0, b = 0, isk, fiyat, giris, tutar, kdv;

                isk = Convert.ToDouble(TextBox8.Text);
                fiyat = Convert.ToDouble(TextBox7.Text);
                kdv = Convert.ToDouble(TextBox9.Text);
                giris = Convert.ToDouble(TextBox5.Text) + Convert.ToDouble(TextBox6.Text);
                a = (((giris * fiyat) * isk) / 100);
                tutar = ((giris * fiyat) - a);
                b = ((tutar * kdv) / 100);
                tutar = (giris * fiyat) + b;
                TextBox10.Text = tutar.ToString();
                TextBox10.TextAlign = HorizontalAlignment.Right;
                TextBox10.Text = String.Format("{0:###,###.00}", Convert.ToDecimal(TextBox10.Text));
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {   baglanti();
            if(TextBox1.Text=="" || TextBox2.Text=="")
            {
             MessageBox.Show("Kaydedilecek Verinin Stok Kodu ve Cinsi seçilmeden Kaydedilme İşlemi yapılamaz.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             Button4.Focus();
                return;
            }
        yeni = true;
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    if(c.Text=="")
                    {
                        MessageBox.Show("Alanları Doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        
             OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKGIRISCIKIS WHERE StokKodu='" + TextBox1.Text + "'", bag);
             OleDbDataReader oku=cmd.ExecuteReader();
            if(oku.HasRows){
                MessageBox.Show("Bu Stok Koduna Ait Kayıt Daha Önce Yapılmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            oku.Close();

        cmd = new OleDbCommand("INSERT INTO STOKGIRISCIKIS(StokKodu,Cinsi,IslemTarihi,MusteriKodu,Aciklama,EvrakNo,GirisMik,CikisMik,BirimFiyat,Iskonto,KDV,Tutari,Birimi,IslemCinsi,OzelNum) Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTimePicker1.Value.Date + "','" + TextBox14.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + ComboBox2.Text + "','" + TextBox12.Text + "')", bag);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Veritabanına Kaydedildi.", "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        oku.Close();

        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "0";
        TextBox6.Text = "0";
        TextBox7.Text = "0";
        TextBox8.Text = "0";
        TextBox9.Text = "0";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox14.Text = "";

        DateTimePicker1.Enabled = false;
        TextBox14.Enabled = false;
        ComboBox2.Enabled = false;
        Button2.Enabled = true;
        Button3.Enabled = false;
        Button4.Enabled = false;
        TextBox3.Enabled = false;
        TextBox4.Enabled = false;
        TextBox5.Enabled = false;
        TextBox6.Enabled = false;
        TextBox7.Enabled = false;
        TextBox8.Enabled = false;
        TextBox9.Enabled = false;
        TextBox10.Enabled = false;
        TextBox11.Enabled = false;
        TextBox12.Enabled = false;

        ComboBox2.SelectedIndex = -1;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
        baglanti();
        OleDbCommand a = new OleDbCommand("SELECT * From STOKGIRISCIKIS where StokKodu='" + TextBox1.Text + "'", bag);
        OleDbDataReader b = a.ExecuteReader();
        b.Read();
        int stok = Convert.ToInt32(b[6].ToString()) + Convert.ToInt32(TextBox5.Text);
        OleDbCommand cmd = new OleDbCommand("UPDATE STOKGIRISCIKIS SET Cinsi='" + TextBox2.Text + "',IslemTarihi='" + DateTimePicker1.Value.Date + "',MusteriKodu='" + TextBox14.Text + "',Aciklama='" + TextBox3.Text + "',EvrakNo='" + TextBox4.Text + "',GirisMik='" + stok.ToString() + "',CikisMik='0',BirimFiyat='" + TextBox7.Text + "',Iskonto='" + TextBox8.Text + "',KDV='" + TextBox9.Text + "',Tutari='" + TextBox10.Text + "',Birimi='" + TextBox11.Text + "',IslemCinsi='" + ComboBox2.Text + "',OzelNum='" + TextBox12.Text + "' WHERE StokKodu='" + TextBox1.Text + "'", bag);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Kayıt Güncellendi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button1_Click(object sender, EventArgs e)
        {   
            baglanti();
            string duzenle;
            duzenle =Microsoft.VisualBasic.Interaction.InputBox("Güncellenecek kaydın Stok Kodunu giriniz.", "DÜZENLEME");
            if(duzenle=="") return;

         OleDbCommand  cmd = new OleDbCommand("SELECT * FROM STOKGIRISCIKIS WHERE StokKodu='" + duzenle + "'", bag);
           OleDbDataReader oku=cmd.ExecuteReader();
        if(oku.Read())
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Enabled=true;
                }
            }
            ComboBox2.Enabled = true;
            Button4.Enabled = true;
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            DateTimePicker1.Enabled = true;

            TextBox1.Text = oku[0].ToString().Trim();
            TextBox2.Text = oku[1].ToString().Trim();
            DateTimePicker1.Text = oku[2].ToString().Trim();
            TextBox14.Text =oku[3].ToString().Trim();
            TextBox3.Text = oku[4].ToString().Trim();
            TextBox4.Text = oku[5].ToString().Trim();
            TextBox5.Text = "0";
            TextBox6.Text = oku[6].ToString().Trim();
            TextBox7.Text = oku[8].ToString().Trim();
            TextBox8.Text = oku[9].ToString().Trim();
            TextBox9.Text = oku[10].ToString().Trim();
            TextBox10.Text = oku[11].ToString().Trim();
            TextBox11.Text = oku[12].ToString().Trim();
            ComboBox2.Text = oku[13].ToString().Trim();
            TextBox12.Text = oku[14].ToString().Trim();

            Button1.Visible = false;
            Button12.Visible = true;

        }else{
        duzenle="";
        MessageBox.Show("Bu stok koduna ait giriş kaydı bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            oku.Close();
            return;
        }
        oku.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            baglanti();
            if(yeni==true)
            {
            MessageBox.Show("Yeni Kayıt modundasınız. Silme işlemi yapılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
            }

        string duzenle;

        duzenle = Microsoft.VisualBasic.Interaction.InputBox("Silinecek kaydın Stok Kodunu giriniz.", "DÜZENLEME");
        if(duzenle=="") return;

        OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKGIRISCIKIS WHERE StokKodu='" + duzenle + "'", bag);
        cmd.ExecuteNonQuery();

        OleDbDataReader oku=cmd.ExecuteReader();
        if(oku.Read())
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Enabled=true;
                }
            }
            ComboBox2.Enabled = true;
            Button1.Enabled = true;

            TextBox1.Enabled = false;
            TextBox2.Enabled = false;

            TextBox1.Text = oku[0].ToString().Trim();
            TextBox2.Text = oku[1].ToString().Trim();
            DateTimePicker1.Text = oku[2].ToString().Trim();
            TextBox14.Text =oku[3].ToString().Trim();
            TextBox3.Text = oku[4].ToString().Trim();
            TextBox4.Text = oku[5].ToString().Trim();
            TextBox5.Text = oku[6].ToString().Trim();
            TextBox6.Text = oku[7].ToString().Trim();
            TextBox7.Text = oku[8].ToString().Trim();
            TextBox8.Text = oku[9].ToString().Trim();
            TextBox9.Text = oku[10].ToString().Trim();
            TextBox10.Text = oku[11].ToString().Trim();
            TextBox11.Text = oku[12].ToString().Trim();
            ComboBox2.Text = oku[13].ToString().Trim();
            TextBox12.Text = oku[14].ToString().Trim();

            Button12.Visible = true;
            Button1.Visible = false;
            oku.Close();

            DialogResult g = MessageBox.Show(duzenle + " nolu Stok Kodu silinecek. Emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
           if(g==DialogResult.Yes)
           {
                cmd = new OleDbCommand("DELETE FROM STOKGIRISCIKIS WHERE StokKodu='" + duzenle + "'", bag);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt veritabanından silindi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);

               foreach(Control c in this.Controls)
               {
                   if(c is TextBox)
                   {
                       c.Text="";
                   }
               }
                DateTimePicker1.Text = "";
                ComboBox2.SelectedIndex = -1;
           }else{

                oku.Close();
               return;
           }
        }else{
            MessageBox.Show("Bu stok koduna ait ürün bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            oku.Close();
            return;
        }
        oku.Close();
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                ErrorProvider1.SetError(TextBox4, "");
            }
            else
            {
                ErrorProvider1.SetError(TextBox4, "Evrak No sadece rakamlardan oluşmalıdır.");
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                ErrorProvider1.SetError(TextBox5, "");
            }
            else
            {
                ErrorProvider1.SetError(TextBox5, "Giriş miktarı sadece rakamlardan oluşmalıdır.");
            }
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                ErrorProvider1.SetError(TextBox8, "");
            }
            else
            {
                ErrorProvider1.SetError(TextBox8, "İskonto oranı sadece rakamlardan oluşmalıdır.");
            }
        }

        private void TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                ErrorProvider1.SetError(TextBox9, "");
            }
            else
            {
                ErrorProvider1.SetError(TextBox9, "KDV oranı sadece rakamlardan oluşmalıdır.");
            }
        }

        private void TextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                ErrorProvider1.SetError(TextBox12, "");
            }
            else
            {
                ErrorProvider1.SetError(TextBox12, "Özel numara sadece rakamlardan oluşmalıdır.");
            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            hesapla();
        }
    }
}
