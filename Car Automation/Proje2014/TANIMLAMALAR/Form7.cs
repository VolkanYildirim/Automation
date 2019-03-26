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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
       public bool k = false;
        public void baglanti() {
            bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ARAC.mdb");
            bag.Open();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (k == true)
            {
                baglanti();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM BIRIMLER", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                Form16 frm16 = new Form16();
                frm16.ComboBox1.Items.Clear();
                while (oku.Read())
                {
                    frm16.ComboBox1.Items.Add(oku[0].ToString());
                }
                oku.Close();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti();
            string birim;
            birim=Microsoft.VisualBasic.Interaction.InputBox("Birim Adı Giriniz.","Birimler");
            if(birim==null) return;
            OleDbCommand cmd=new OleDbCommand("SELECT * From BIRIMLER Where Birim='"+birim+"'",bag);
            OleDbDataReader oku=cmd.ExecuteReader();

            if(oku.HasRows){
            MessageBox.Show("Bu Birim Kaydı Daha Önce Yapılmış.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oku.Close();
            listBox1.Items.Add(birim);
            cmd=new OleDbCommand("INSERT INTO BIRIMLER(Birim) Values ('"+birim+"')",bag);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Veritabanına Kaydedildi.", "İŞLEM TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti();
            if(listBox1.SelectedIndex==-1) {
            MessageBox.Show("Listeden silinecek birimi seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            } else{
           textBox1.Text = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                OleDbCommand cmd=new OleDbCommand("DELETE FROM BIRIMLER where Birim='"+textBox1.Text.Trim()+"'",bag);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt veritabanından silindi.", "İŞLEM TAMAM", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti();
        Form16 frm16 = (Form16)Application.OpenForms["Form16"];
        frm16.ComboBox1.Items.Clear();
        OleDbCommand cmd = new OleDbCommand("SELECT * FROM BIRIMLER", bag);
        OleDbDataReader oku = cmd.ExecuteReader();
        while (oku.Read()){
            frm16.ComboBox1.Items.Add(oku[0].ToString());
        }
        oku.Close();
        this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {baglanti();
            if(k==true)
                button3.Enabled=true;
          OleDbCommand cmd=new OleDbCommand("SELECT * FROM BIRIMLER",bag);
        OleDbDataReader oku = cmd.ExecuteReader();
        listBox1.Items.Clear();
        while (oku.Read())
            listBox1.Items.Add(oku[0].ToString());

        oku.Close();
        }
    }
}
