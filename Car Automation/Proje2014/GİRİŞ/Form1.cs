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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            pictureBox1.BackColor = Color.Transparent;
        }
        OleDbConnection bag;
        public void baglanti()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ARAC.mdb");
            bag.Open();
        }
        public void vericekme()
        {
            comboBox1.Items.Clear();
                baglanti();
                OleDbDataReader oku;
                OleDbCommand veri = new OleDbCommand("SELECT * From SIRKETGIRIS",bag);
            
                oku = veri.ExecuteReader();
                comboBox1.Items.Add("Şirket Seçiniz...");
                comboBox1.SelectedIndex = 0;
                while(oku.Read()){
                    comboBox1.Items.Add(oku[0]);
                   
                }
                oku.Close();
                bag.Close();
                
            }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../../img/logout.png");
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../../img/logout2.png");
}

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            if (degis)
            {
                DialogResult a = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                if (a == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }else
                Application.Exit();
        }
        bool degis = false;
        public string sifre,ad;
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti();
            OleDbDataReader oku;
            OleDbCommand veri = new OleDbCommand("SELECT * From SIRKETGIRIS where SirketKodu='"+comboBox1.Text+"'", bag);

            oku = veri.ExecuteReader();
            while (oku.Read())
            {
                textBox1.Text=oku[1].ToString();
                sifre = oku[2].ToString();
                ad = oku[1].ToString();
            }
            oku.Close();
            bag.Close();
            if (comboBox1.SelectedIndex > 0)
            {
                degis = true;
                textBox2.Focus();
            }
            
            if(comboBox1.SelectedIndex!=0)
               textBox2.BackColor = Color.LightGreen;
            else
                textBox2.BackColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
          textBox2.BackColor = Color.LightGreen;
        }

        private void Form1_Load(object sender, EventArgs e)
             {
             vericekme();
             comboBox1.SelectedIndex = 0; 
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedIndex == 0) {
                MessageBox.Show("Şirket Kodu Seçmelisiniz.!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                
            }
            else if (sifre != textBox2.Text || textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
                MessageBox.Show("Girdiğiniz Şifre Hatalı.!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                textBox2.Clear();
                textBox2.Focus();
            } else {
                this.Hide();
                Form form4 = new Form4();
                form4.Show();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }
    }
}
