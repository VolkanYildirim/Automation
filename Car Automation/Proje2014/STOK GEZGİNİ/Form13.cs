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
namespace Proje1
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        public void baglanti() {
            bag =new  OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ARAC.mdb");
            bag.Open();
        }
        public void tumkayitlar() {
            baglanti();
            DataGridView1.Rows.Clear();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI ORDER BY StokKodu ASC", bag);
            OleDbDataReader oku = cmd.ExecuteReader();
            
            while (oku.Read())
            {
                OleDbCommand a = new OleDbCommand("SELECT * From STOKGIRISCIKIS where StokKodu='" + oku[0].ToString() + "'",bag);
                OleDbDataReader b = a.ExecuteReader();
                if (b.HasRows)
                {
                    b.Read();
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString(), b[6].ToString());
                }
                else {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());

                }
            }
            oku.Close();
        
        }
        public void duzenle() {
            baglanti();
            Form16 frm16 = new Form16();
            frm16.TextBox1.Enabled = false;
            frm16.TextBox2.Enabled = false;
            frm16.ComboBox1.Enabled = false;
            frm16.ComboBox2.Enabled = false;
            frm16.ComboBox3.Enabled = false;
            frm16.TextBox3.Enabled = false;
            frm16.TextBox4.Enabled = false;
            frm16.TextBox5.Enabled = false;
            frm16.TextBox6.Enabled = false;
            frm16.TextBox9.Enabled = false;
            frm16.TextBox10.Enabled = false;
            frm16.TextBox7.Enabled = false;
            frm16.TextBox8.Enabled = false;
            frm16.Button1.Enabled = false;
            frm16.Button2.Enabled = false;
            frm16.Button8.Enabled = false;
            frm16.Button9.Enabled = false;
            frm16.Button10.Enabled = false;
            frm16.Button11.Enabled = false;
            frm16.PictureBox1.Image = null;
            frm16.Button4.Visible = true;
            frm16.Button12.Visible = false;

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE StokKodu='" + DataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", bag);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                frm16.TextBox1.Text = oku[0].ToString().Trim();
                frm16.TextBox2.Text = oku[1].ToString().Trim();
                frm16.ComboBox1.Text = oku[2].ToString().Trim();
                frm16.ComboBox2.Text = oku[3].ToString().Trim();
                frm16.ComboBox3.Text = oku[4].ToString().Trim();
                frm16.TextBox3.Text = oku[5].ToString().Trim();
                frm16.TextBox4.Text = oku[6].ToString().Trim();
                frm16.TextBox5.Text = oku[7].ToString().Trim();
                frm16.TextBox6.Text = oku[8].ToString().Trim();
                frm16.TextBox9.Text = oku[9].ToString().Trim();
                frm16.TextBox10.Text = oku[10].ToString().Trim();
                frm16.TextBox7.Text = oku[11].ToString().Trim();
                frm16.TextBox8.Text = oku[12].ToString().Trim();
                //frm16.PictureBox1.Image = Image.FromFile(oku[13].ToString());
            }
            oku.Close();
            frm16.ShowDialog();
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            tumkayitlar();
             ToolStripTextBox1.Text = "Aranacak Kelimeyi Giriniz...";
             ToolStripTextBox1.BackColor = Color.Orange;

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StokKoduToolStripMenuItem_Click(object sender, EventArgs e)
        {
               if(StokKoduToolStripMenuItem.Checked)
               {
                    StokKoduToolStripMenuItem.Checked=false;
               }else{
               ToolStripLabel1.Visible = true;
            ToolStripTextBox1.Visible = true;
            ToolStripLabel1.Text = "Stok Kodu: ";
            StokKoduToolStripMenuItem.Checked = true;
            CinsiToolStripMenuItem.Checked = false;
            BirimiToolStripMenuItem.Checked = false;
            SınıfıToolStripMenuItem.Checked = false;
            GrubuToolStripMenuItem.Checked = false;
            RafNumarasıToolStripMenuItem.Checked = false;
            GözNumarasıToolStripMenuItem.Checked = false;
            AçıklamaToolStripMenuItem.Checked = false;
            FiyatToolStripMenuItem.Checked = false;
            TümKayıtlarıGösterToolStripMenuItem.Checked = false;
               }

        }

        private void CinsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CinsiToolStripMenuItem.Checked)
            {
                CinsiToolStripMenuItem.Checked = false;
            }
            else
            {
                ToolStripLabel1.Visible = true;
                ToolStripTextBox1.Visible = true;
                ToolStripLabel1.Text = "Cinsi: ";
                CinsiToolStripMenuItem.Checked = true;
                StokKoduToolStripMenuItem.Checked = false;
                BirimiToolStripMenuItem.Checked = false;
                SınıfıToolStripMenuItem.Checked = false;
                GrubuToolStripMenuItem.Checked = false;
                RafNumarasıToolStripMenuItem.Checked = false;
                GözNumarasıToolStripMenuItem.Checked = false;
                AçıklamaToolStripMenuItem.Checked = false;
                FiyatToolStripMenuItem.Checked = false;
                TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void BirimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(BirimiToolStripMenuItem.Checked)
                BirimiToolStripMenuItem.Checked=false;
            else
            {
            ToolStripLabel1.Visible = true;
            ToolStripTextBox1.Visible = true;
            ToolStripLabel1.Text = "Birimi: ";
            BirimiToolStripMenuItem.Checked = true;
            StokKoduToolStripMenuItem.Checked = false;
            CinsiToolStripMenuItem.Checked = false;
            SınıfıToolStripMenuItem.Checked = false;
            GrubuToolStripMenuItem.Checked = false;
            RafNumarasıToolStripMenuItem.Checked = false;
            GözNumarasıToolStripMenuItem.Checked = false;
            AçıklamaToolStripMenuItem.Checked = false;
            FiyatToolStripMenuItem.Checked = false;
            TümKayıtlarıGösterToolStripMenuItem.Checked = false;
        }
        }

        private void SınıfıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(SınıfıToolStripMenuItem.Checked)
                SınıfıToolStripMenuItem.Checked=false;
            else{
            ToolStripLabel1.Visible = true;
            ToolStripTextBox1.Visible = true;
            ToolStripLabel1.Text = "Sınıfı: ";
            SınıfıToolStripMenuItem.Checked = true;
            StokKoduToolStripMenuItem.Checked = false;
            CinsiToolStripMenuItem.Checked = false;
            BirimiToolStripMenuItem.Checked = false;
            GrubuToolStripMenuItem.Checked = false;
            RafNumarasıToolStripMenuItem.Checked = false;
            GözNumarasıToolStripMenuItem.Checked = false;
            AçıklamaToolStripMenuItem.Checked = false;
            FiyatToolStripMenuItem.Checked = false;
            TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void GrubuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GrubuToolStripMenuItem.Checked)
                GrubuToolStripMenuItem.Checked=false;
            else{
            ToolStripLabel1.Visible = true;
            ToolStripTextBox1.Visible = true;
            ToolStripLabel1.Text = "Grubu: ";
            GrubuToolStripMenuItem.Checked = true;
            StokKoduToolStripMenuItem.Checked = false;
            CinsiToolStripMenuItem.Checked = false;
            BirimiToolStripMenuItem.Checked = false;
            SınıfıToolStripMenuItem.Checked = false;
            RafNumarasıToolStripMenuItem.Checked = false;
            GözNumarasıToolStripMenuItem.Checked = false;
            AçıklamaToolStripMenuItem.Checked = false;
            FiyatToolStripMenuItem.Checked = false;
            TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void RafNumarasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RafNumarasıToolStripMenuItem.Checked)
                RafNumarasıToolStripMenuItem.Checked = false;
            else
            {
                ToolStripLabel1.Visible = true;
                ToolStripTextBox1.Visible = true;
                ToolStripLabel1.Text = "Raf No: ";
                RafNumarasıToolStripMenuItem.Checked = true;
                StokKoduToolStripMenuItem.Checked = false;
                CinsiToolStripMenuItem.Checked = false;
                BirimiToolStripMenuItem.Checked = false;
                SınıfıToolStripMenuItem.Checked = false;
                GrubuToolStripMenuItem.Checked = false;
                GözNumarasıToolStripMenuItem.Checked = false;
                AçıklamaToolStripMenuItem.Checked = false;
                FiyatToolStripMenuItem.Checked = false;
                TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void GözNumarasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GözNumarasıToolStripMenuItem.Checked)
                GözNumarasıToolStripMenuItem.Checked = false;
            else
            {
                ToolStripLabel1.Visible = true;
                ToolStripTextBox1.Visible = true;
                ToolStripLabel1.Text = "Göz No: ";
                GözNumarasıToolStripMenuItem.Checked = true;
                StokKoduToolStripMenuItem.Checked = false;
                CinsiToolStripMenuItem.Checked = false;
                BirimiToolStripMenuItem.Checked = false;
                SınıfıToolStripMenuItem.Checked = false;
                GrubuToolStripMenuItem.Checked = false;
                RafNumarasıToolStripMenuItem.Checked = false;
                AçıklamaToolStripMenuItem.Checked = false;
                FiyatToolStripMenuItem.Checked = false;
                TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void AçıklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AçıklamaToolStripMenuItem.Checked)
                AçıklamaToolStripMenuItem.Checked = false;
            else
            {
                ToolStripLabel1.Visible = true;
                ToolStripTextBox1.Visible = true;
                ToolStripLabel1.Text = "Açıklama: ";
                AçıklamaToolStripMenuItem.Checked = true;
                StokKoduToolStripMenuItem.Checked = false;
                CinsiToolStripMenuItem.Checked = false;
                BirimiToolStripMenuItem.Checked = false;
                SınıfıToolStripMenuItem.Checked = false;
                GrubuToolStripMenuItem.Checked = false;
                RafNumarasıToolStripMenuItem.Checked = false;
                GözNumarasıToolStripMenuItem.Checked = false;
                FiyatToolStripMenuItem.Checked = false;
                TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void FiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FiyatToolStripMenuItem.Checked)
                FiyatToolStripMenuItem.Checked = false;
            else{
            ToolStripLabel1.Visible = true;
            ToolStripTextBox1.Visible = true;
            ToolStripLabel1.Text = "Fiyat: ";
            FiyatToolStripMenuItem.Checked = true; 
            StokKoduToolStripMenuItem.Checked = false;
            CinsiToolStripMenuItem.Checked = false;
            BirimiToolStripMenuItem.Checked = false;
            SınıfıToolStripMenuItem.Checked = false;
            GrubuToolStripMenuItem.Checked = false;
            RafNumarasıToolStripMenuItem.Checked = false;
            GözNumarasıToolStripMenuItem.Checked = false;
            AçıklamaToolStripMenuItem.Checked = false;
            TümKayıtlarıGösterToolStripMenuItem.Checked = false;
            }
        }

        private void TümKayıtlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tumkayitlar();
        if (TümKayıtlarıGösterToolStripMenuItem.Checked == false){
            ToolStripLabel1.Visible = false;
            ToolStripTextBox1.Visible = false;
            TümKayıtlarıGösterToolStripMenuItem.Checked = true;
            StokKoduToolStripMenuItem.Checked = false;
            CinsiToolStripMenuItem.Checked = false;
            BirimiToolStripMenuItem.Checked = false;
            SınıfıToolStripMenuItem.Checked = false;
            GrubuToolStripMenuItem.Checked = false;
            RafNumarasıToolStripMenuItem.Checked = false;
            GözNumarasıToolStripMenuItem.Checked = false;
            AçıklamaToolStripMenuItem.Checked = false;
            FiyatToolStripMenuItem.Checked = false;
        } else{
            TümKayıtlarıGösterToolStripMenuItem.Checked = false;
        }
        }

        private void ToolStripTextBox1_Enter(object sender, EventArgs e)
        {
            ToolStripTextBox1.Clear();
            if(ToolStripTextBox1.Text.Length<1)
                ToolStripTextBox1.BackColor=Color.DarkRed;
            else
                ToolStripTextBox1.BackColor=Color.LimeGreen;
        }

        private void ToolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti();
            DataGridView1.Rows.Clear();
            if (ToolStripTextBox1.Text.Length < 1)
                ToolStripTextBox1.BackColor = Color.DarkRed;
            else
                ToolStripTextBox1.BackColor = Color.LimeGreen;

            if (StokKoduToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE StokKodu LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }

            if (CinsiToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE Cinsi LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }

            if (BirimiToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE Birimi LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
            if (SınıfıToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE Sinifi LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
            if (GrubuToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE Grubu LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
            if (RafNumarasıToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE RafNo LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
            if (GözNumarasıToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE GozNo LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
            if (AçıklamaToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE Aciklama LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
            if (FiyatToolStripMenuItem.Checked)
            {
                DataGridView1.Rows.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI WHERE Fiyat LIKE '%" + ToolStripTextBox1.Text + "%'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[3].ToString(), oku[4].ToString(), oku[5].ToString(), oku[6].ToString(), oku[7].ToString(), oku[8].ToString());
                }
                oku.Close();
            }
        }

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
        DialogResult g;
        g = MessageBox.Show(DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + " nolu Stok Kodu silinecek. Emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        if(g==DialogResult.Yes)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM STOKKARTI WHERE StokKodu='" + DataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + "'", bag);
            cmd.ExecuteNonQuery();
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow);
            MessageBox.Show("Kayıt veritabanından silindi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(DataGridView1.RowCount==0)
                ContextMenuStrip1.Enabled=false;
            else
                ContextMenuStrip1.Enabled=true;

        }

        private void DüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            duzenle();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            duzenle();
        }
        }
    }

