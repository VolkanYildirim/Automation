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
using System.Text.RegularExpressions;

namespace Proje2014
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        public void baglanti()
        {
            try
            {
                bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=STOKTAKIP.mdb");
                bag.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        public void veriekle(string kod, String ad, string sifre)
        {
            baglanti();
            OleDbCommand kayıtsorgusu = new OleDbCommand("INSERT Into SIRKETGIRIS (SirketKodu,SirketAdi,Sifre) Values('" + kod + "','" + ad + "','" + sifre + "')");

            kayıtsorgusu.Connection = bag;

            kayıtsorgusu.ExecuteNonQuery();
            MessageBox.Show("Yeni Şirket Bilgileri  Kaydedildi");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            bag.Close();
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.vericekme();
        }
        public string cagir()
    {
        baglanti();
        OleDbDataReader oku;
        OleDbCommand veri = new OleDbCommand("SELECT * From SIRKETGIRIS where SirketKodu='" +textBox1.Text+ "'", bag);

        oku = veri.ExecuteReader();
       string a = "false";
            if (oku.HasRows)
            {
                MessageBox.Show("Bu Şirket Zaten Ekli");

                a = "true";
                    
                
            }
        oku.Close();
        bag.Close();


        return a;

    }
        public bool control(string a)
        {
            string desen = @"[0-9]";
            Match rgx = Regex.Match(a, desen);

            return rgx.Success;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a=cagir();
           
            if (a != "true")
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurunuz..");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }

                else if (!control(textBox1.Text))
                {
                    MessageBox.Show("Şirket Kodu Harf İçeremez!!!");
                }
                
                else
                    veriekle(textBox1.Text, textBox2.Text, textBox3.Text);
            }
           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
