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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        public bool k = false;
        public void baglanti()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ARAC.mdb");
            bag.Open();
        }

        private void button4_Click(object sender, EventArgs e)
        {  
            if(k==true){
            baglanti();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM GRUPLAR", bag);
            OleDbDataReader oku = cmd.ExecuteReader();
            Form16 frm16 = (Form16)Application.OpenForms["Form16"];
            frm16.ComboBox3.Items.Clear();
            while (oku.Read())
            {
                frm16.ComboBox3.Items.Add(oku[0].ToString());
            }
            oku.Close();
            this.Close();
            }else{
            this.Close();
            }

            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if (k == true)
                button3.Enabled = true;
            baglanti();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM GRUPLAR", bag);
            OleDbDataReader oku = cmd.ExecuteReader();
            listBox1.Items.Clear();
            while (oku.Read())
                listBox1.Items.Add(oku[0].ToString());

            oku.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti();
            string birim;
            birim = Microsoft.VisualBasic.Interaction.InputBox("Grup Adı Giriniz.", "Gruplar");
            if (birim == null) return;
            OleDbCommand cmd = new OleDbCommand("SELECT * From GRUPLAR Where Grup='" + birim + "'", bag);
            OleDbDataReader oku = cmd.ExecuteReader();

            if (oku.HasRows)
            {
                MessageBox.Show("Bu Grup Kaydı Daha Önce Yapılmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oku.Close();
            listBox1.Items.Add(birim);
            cmd = new OleDbCommand("INSERT INTO GRUPLAR(Grup) Values ('" + birim + "')", bag);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Veritabanına Kaydedildi.", "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti();
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Listeden silinecek birimi seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                OleDbCommand cmd = new OleDbCommand("DELETE FROM GRUPLAR where Grup='" + textBox1.Text.Trim() + "'", bag);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt veritabanından silindi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             baglanti();
        Form16 frm16 = (Form16)Application.OpenForms["Form16"];
        frm16.ComboBox3.Items.Clear();
        OleDbCommand cmd = new OleDbCommand("SELECT * FROM GRUPLAR", bag);
        OleDbDataReader oku = cmd.ExecuteReader();
        while (oku.Read()){
            frm16.ComboBox3.Items.Add(oku[0].ToString());
        }
        oku.Close();
        this.Close();
        }
        }
    }


