using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Globalization;
namespace Proje2014
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        public bool yeni;
        public bool ekle;
        string a;
        OleDbConnection bag;
        public void baglanti() {
             bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=STOKTAKIP.mdb");
            bag.Open();
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            yeni = true;
            Button1.Enabled = true;
            Button2.Enabled = false;
            Button3.Enabled = true;
            Button4.Enabled = false;
            Button8.Enabled = true;
            Button9.Enabled = true;
            Button10.Enabled = true;
            Button11.Enabled = true;

            foreach (Control b in this.Controls)
            {
                if (b is TextBox)
                {
                    b.Text="";
                    b.Enabled = true;
                }
            }
            ComboBox1.Enabled = true;
            ComboBox2.Enabled = true;
            ComboBox3.Enabled = true;
            TextBox1.Focus();
        ComboBox1.SelectedIndex = -1;
        ComboBox2.SelectedIndex = -1;
        ComboBox3.SelectedIndex = -1;
        PictureBox1.Image=null;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
        OpenFileDialog1.Filter = "Resim Dosyaları|" + "*.jpg;*.png;*.gif";
        DialogResult cevap = OpenFileDialog1.ShowDialog();
       
         if (cevap==DialogResult.OK)
        {
        PictureBox1.Image=Image.FromFile(OpenFileDialog1.FileName);
            a=OpenFileDialog1.FileName;
            OpenFileDialog1.Reset();
        }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = null;
        }

        private void Form16_Shown(object sender, EventArgs e)
        {
            Button2.Enabled = true;
            Button3.Enabled=false;
            Button4.Enabled = true;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
              
            yeni = true;
            if(yeni==true)
                ErrorProvider1.SetError(Button3,"");

        if(yeni==false){
            MessageBox.Show("Yeni Kayıt Modundasınız .","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            return;
        }
        if (TextBox1.Text != "")
        {
            Form17 frm17 = new Form17();
            frm17.TextBox1.Text = TextBox1.Text;
            frm17.TextBox2.Text = TextBox2.Text;
            frm17.ShowDialog();
        }
        else {
            MessageBox.Show("Barkod Tanımlayabilmek İçin Stok Kodu Girmelisiniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if(yeni==true)
            {
            MessageBox.Show("Yeni Kayıt modundasınız. Silme işlemi yapılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        string duzenle;
        duzenle = Microsoft.VisualBasic.Interaction.InputBox("Silinecek Kaydın Stok Kodunu Giriniz","Silme");
           if(duzenle=="") return;
            
            baglanti();
            OleDbCommand cmd=new OleDbCommand("SELECT * FROM STOKKARTI Where StokKodu='"+duzenle+"'",bag);
               cmd.ExecuteNonQuery();
            OleDbDataReader oku=cmd.ExecuteReader();
            if(oku.Read()){
                foreach(Control c in this.Controls){
                    if(c is TextBox )
                        c.Enabled = true;
                }

            ComboBox1.Enabled = true;
            ComboBox2.Enabled = true;
            ComboBox3.Enabled = true;
            Button1.Enabled = true;
            Button8.Enabled = true;
            Button9.Enabled = true;
            Button10.Enabled = true;
            Button11.Enabled = true;

            TextBox1.Enabled = false;
            TextBox1.Text=oku[0].ToString().Trim();
            TextBox2.Text=oku[1].ToString().Trim();
            ComboBox1.Text=oku[2].ToString().Trim();
            ComboBox2.Text=oku[3].ToString().Trim();
            ComboBox3.Text=oku[4].ToString().Trim();
            TextBox3.Text=oku[5].ToString().Trim();
            TextBox4.Text=oku[6].ToString().Trim();
            TextBox5.Text=oku[7].ToString().Trim();
            TextBox6.Text=oku[8].ToString().Trim();
            TextBox9.Text=oku[9].ToString().Trim();
            TextBox10.Text=oku[10].ToString().Trim();
            TextBox7.Text=oku[11].ToString().Trim();
            TextBox8.Text=oku[12].ToString().Trim();
            if(oku[13].ToString()!="")
                PictureBox1.Image=Image.FromFile(oku[13].ToString());
           
            Button12.Visible = true;
            Button4.Visible = false;
                    oku.Close();
                  DialogResult cevap=MessageBox.Show(duzenle+" nolu Stok Kodu silinibnecek. Emin Misiniz?","DİKKAT",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);  
                    if(cevap==DialogResult.Yes)
                    {
                        cmd=new OleDbCommand("DELETE From STOKKARTI Where StokKodu='"+duzenle+"'",bag);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt veritabanından silindi.","İŞLEM TAMAM",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    foreach(Control c in this.Controls)
                    {
                        if (c is TextBox)
                            c.Text="";

                    }
                ComboBox1.SelectedIndex = -1;
                ComboBox2.SelectedIndex = -1;
                ComboBox3.SelectedIndex = -1;
                PictureBox1.Image = null;

                }else{
                    oku.Close();
                    return;
                    } 
            }else {
            MessageBox.Show("Bu stok koduna ait ürün bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            oku.Close();
                return;
            }
            oku.Close();
            }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form7 frm7 =new Form7();
            frm7.k = true;    
            frm7.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.k = true;
            frm8.ShowDialog();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.k = true;
            frm9.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            baglanti();
            if(ekle==true){
                ekle = false;
                ErrorProvider1.SetError(Button3,"");
                    foreach(Control c in this.Controls){
                        if (c is TextBox)
                        {
                            if (c.Text == "")
                            {
                                MessageBox.Show("Alanları Doldurunuz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    OleDbCommand cmd=new OleDbCommand("SELECT * FROM STOKKARTI WHERE StokKodu='" + TextBox1.Text + "'", bag);
                    OleDbDataReader oku=cmd.ExecuteReader();
                    if (oku.HasRows){
                        MessageBox.Show("Bu Stok Koduna Ait Kayıt Daha Önce Yapılmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    oku.Close();
             
                cmd = new OleDbCommand("INSERT INTO STOKKARTI(StokKodu,Cinsi,Birimi,Sinifi,Grubu,RafNo,GozNo,Aciklama,Fiyat,OzelKod1,OzelKod2,IskontoOrani,KDVOrani,StokResmi) Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + ComboBox3.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + a + "')", bag);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Veritabanına Kaydedildi.", "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Button4.Enabled = true;
            }else{
                ErrorProvider1.SetError(Button3, "Yeni Kayıt Eklenmeden önce Barkod Tanımlanmalıdır.");
                return;
            }
                yeni = false;
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                        c.Text = "";
                }
                ComboBox1.SelectedIndex = -1;
                ComboBox2.SelectedIndex = -1;
                ComboBox3.SelectedIndex = -1;
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                ComboBox1.Enabled = false;
                ComboBox2.Enabled = false;
                ComboBox3.Enabled = false;
                TextBox3.Enabled = false;
                TextBox4.Enabled = false;
                TextBox5.Enabled = false;
                TextBox6.Enabled = false;
                TextBox9.Enabled = false;
                TextBox10.Enabled = false;
                TextBox7.Enabled = false;
                TextBox8.Enabled = false;
                Button1.Enabled = false;
                Button8.Enabled = false;
                Button9.Enabled = false;
                Button10.Enabled = false;
                Button11.Enabled = false;
                PictureBox1.Image = null;
                Button4.Visible = true;
                Button12.Visible = false;

                Button3.Enabled = false;
                Button2.Enabled = true;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))) { 
                ErrorProvider1.SetError(TextBox1, "");
            }else{
                ErrorProvider1.SetError(TextBox1, "Stok Kodu sadece rakamlardan oluşmalıdır.");
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            baglanti();
             yeni = false;
             OleDbCommand cmd=new OleDbCommand("UPDATE STOKKARTI SET Cinsi='" + TextBox2.Text + "',Birimi='" + ComboBox1.Text + "',Sinifi='" + ComboBox2.Text + "',Grubu='" + ComboBox3.Text + "',RafNo='" + TextBox3.Text + "',GozNo='" + TextBox4.Text + "',Aciklama='" + TextBox5.Text + "',Fiyat='" +TextBox6.Text + "',OzelKod1='" + TextBox9.Text + "',OzelKod2='" + TextBox10.Text + "',IskontoOrani='" +TextBox7.Text + "',KDVOrani='" + TextBox8.Text + "',StokResmi='" + a + "' Where StokKodu='" + TextBox1.Text + "'", bag);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Kayıt Güncellendi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
             Form13 frm13 = new Form13();
             frm13.tumkayitlar();
        }

        private void Button4_Click(object sender, EventArgs e)
        {   baglanti();
            string duzen;
            if (TextBox1.Text == "" || TextBox2.Text == "") { 
                duzen =Microsoft.VisualBasic.Interaction.InputBox("Güncellenecek kaydın Stok Kodunu giriniz.", "DÜZENLEME");
                if(duzen=="") return;
                OleDbCommand cmd=new OleDbCommand("SELECT * FROM STOKKARTI WHERE StokKodu='" + duzen + "'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                if(oku.Read()){
                    foreach(Control c in this.Controls)
                    {
                        if(c is TextBox)
                        {
                            c.Enabled=true;
                        }
                    }
                    ComboBox1.Enabled = true;
                    ComboBox2.Enabled = true;
                    ComboBox3.Enabled = true;
                    Button1.Enabled = true;
                    Button8.Enabled = true;
                    Button9.Enabled = true;
                    Button10.Enabled = true;
                    Button11.Enabled = true;   
                    TextBox1.Enabled = false;
                    TextBox1.Text = oku[0].ToString().Trim();
                    TextBox2.Text = oku[1].ToString().Trim();
                    ComboBox1.Text =oku[2].ToString().Trim(); 
                    ComboBox2.Text = oku[3].ToString().Trim();
                ComboBox3.Text = oku[4].ToString().Trim();
                TextBox3.Text = oku[5].ToString().Trim();
                TextBox4.Text = oku[6].ToString().Trim();
                TextBox5.Text = oku[7].ToString().Trim();
                TextBox6.Text = oku[8].ToString().Trim();
                TextBox9.Text = oku[9].ToString().Trim();
                TextBox10.Text = oku[10].ToString().Trim();
                TextBox7.Text = oku[11].ToString().Trim();
                TextBox8.Text = oku[12].ToString().Trim();
                if (oku[13].ToString() != "")
                {
                    PictureBox1.Image = Image.FromFile(oku[13].ToString());
                }
                Button12.Visible = true;
                Button4.Visible = false;
                }else{
                duzen = "";
                MessageBox.Show("Bu stok koduna ait ürün bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oku.Close();
                return;
                }
                oku.Close();
            }else{
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Enabled=true;
                }
            }
                Form13 frm13 = (Form13)Application.OpenForms["Form13"];
                OleDbCommand cmd=new OleDbCommand("SELECT * FROM STOKKARTI WHERE StokKodu='" +frm13.DataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
                OleDbDataReader oku=cmd.ExecuteReader();
                if(oku.Read())
                {
                    ComboBox1.Enabled = true;
                    ComboBox2.Enabled = true;  
                    ComboBox3.Enabled = true;
                    ComboBox1.Text = oku[2].ToString().Trim();
                    ComboBox2.Text = oku[3].ToString().Trim();
                    ComboBox3.Text = oku[4].ToString().Trim();
                    
                    Button1.Enabled = true;
                    Button8.Enabled = true;
                    Button9.Enabled = true;
                    Button10.Enabled = true;
                    Button11.Enabled = true;
                    TextBox1.Enabled = false;
                    Button12.Visible = true;
                    Button4.Visible = false;
                }
            }
                
         }
        public void listele(string a,int b) {
            baglanti();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM "+a, bag);
            OleDbDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {   
                if(b==1)
                    ComboBox1.Items.Add(oku[0].ToString());
                else if(b==2)
                    ComboBox2.Items.Add(oku[0].ToString());
                else if(b==3)
                    ComboBox3.Items.Add(oku[0].ToString());

            }
            oku.Close();
        }
        private void Form16_Load(object sender, EventArgs e)
        {   baglanti();
             Timer1.Enabled = true;
             Label16.Text = DateAndTime.Now.ToLongDateString();
        //-------------------------Listele---------------------------------
             ComboBox1.Items.Clear();
             ComboBox2.Items.Clear();
             ComboBox3.Items.Clear();
             listele("BIRIMLER",1);
             listele("SINIFLAR", 2);
             listele("GRUPLAR", 3);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Label17.Text = DateAndTime.TimeOfDay.ToLongTimeString();
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            try
            {
                TextBox6.TextAlign = HorizontalAlignment.Right;
                TextBox6.Text = String.Format("{0:###,###.00}", Convert.ToDecimal(TextBox6.Text));
                TextBox9.Focus();
            }
            catch{
                MessageBox.Show("Geçersiz Para Formatı!");
            }
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                ErrorProvider1.SetError(TextBox6, "");
            }
            else
            {
                ErrorProvider1.SetError(TextBox6, "Fiyat sadece rakamlardan oluşmalıdır.");
            }
        }
      }
    }    



