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
namespace Proje2014
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        public void baglanti(){
            bag=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=STOKTAKIP.mdb");
            bag.Open();
        }
        private void Button1_Click(object sender, EventArgs e)
        {   
            baglanti();
            if(TextBox3.Text=="" || TextBox4.Text==""){
                MessageBox.Show("Barkod Numarası ve Tanım alanlarını doldurunuz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        OleDbCommand cmd = new OleDbCommand("INSERT INTO BARKOD(BarkodNo,Tanim,StokKodu) Values('" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox1.Text + "')", bag);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Veritabanına Kaydedildi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DataGridView1.Rows.Clear();
        TextBox3.Clear();
        TextBox4.Clear();
        cmd = new OleDbCommand("SELECT * FROM BARKOD ORDER BY BarkodNo ASC", bag);
        OleDbDataReader oku=cmd.ExecuteReader();
        while (oku.Read())
            DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString());
        
        oku.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        DialogResult g;
        g = MessageBox.Show(DataGridView1.CurrentRow.Cells[0].Value + " nolu Barkod Kodu silinecek. Emin misiniz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        if(g==DialogResult.Yes){
        OleDbCommand cmd=new OleDbCommand("DELETE FROM BARKOD WHERE BarkodNo=" +Convert.ToInt32(DataGridView1.CurrentRow.Cells[0].Value), bag);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Barkod veritabanından silindi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        DataGridView1.Rows.Clear();
            TextBox3.Clear();
            TextBox4.Clear();
        cmd=new OleDbCommand("SELECT * FROM BARKOD ORDER BY BarkodNo ASC", bag);
            OleDbDataReader oku=cmd.ExecuteReader();
            while(oku.Read())
                DataGridView1.Rows.Add(oku[0].ToString(),oku[1].ToString());
            oku.Close();
        }else{
        return;
        }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form17_Load(object sender, EventArgs e)
        {   baglanti();
            DataGridView1.Rows.Clear();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM BARKOD ORDER BY BarkodNo ASC", bag);

            OleDbDataReader oku=cmd.ExecuteReader();
            while(oku.Read())
                DataGridView1.Rows.Add(oku[0].ToString(),oku[1].ToString());

            oku.Close();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Form16 frm16 = (Form16)Application.OpenForms["Form16"]; 
            frm16.yeni = false;
            frm16.ekle = true;
            MessageBox.Show(TextBox1.Text + " nolu Stok Koduna "+ DataGridView1.CurrentRow.Cells[0].Value.ToString() +"Numaralı Barkod Tanımlanmıştır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
