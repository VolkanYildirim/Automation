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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        public bool gelen;
        public void baglanti() {
            bag = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=ARAC.mdb");
            bag.Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void aktar()
        {
            if (gelen == true)
            {
                Form10 frm10 = (Form10)Application.OpenForms["Form10"];

                frm10.TextBox3.Text = "";
                frm10.TextBox4.Text = "";
                frm10.TextBox5.Text = "0";
                frm10.TextBox6.Text = "0";
                frm10.TextBox7.Text = "0";
                frm10.TextBox8.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                frm10.TextBox9.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[5].Value.ToString().Trim();
                frm10.TextBox11.Text = "";
                frm10.TextBox12.Text = "";
                frm10.TextBox14.Text = "";

                frm10.ComboBox2.SelectedIndex = -1;

                frm10.TextBox1.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                frm10.TextBox2.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                frm10.TextBox7.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[6].Value.ToString().Trim();
                frm10.TextBox11.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();
                this.Close();
            }
            else if (gelen == false)
            {
                Form12 frm12 = (Form12)Application.OpenForms["Form12"];
                frm12.TextBox3.Text = "";
                frm12.TextBox4.Text = "";
                frm12.TextBox5.Text = "0";
                frm12.TextBox6.Text = "0";
                frm12.TextBox7.Text = "0";
                frm12.TextBox8.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[4].Value.ToString().Trim();
                frm12.TextBox9.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[5].Value.ToString().Trim();
                frm12.TextBox11.Text = "";
                frm12.TextBox12.Text = "";
                frm12.TextBox14.Text = "";

                frm12.ComboBox2.SelectedIndex = -1;

                frm12.TextBox1.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[0].Value.ToString().Trim();
                frm12.TextBox2.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[1].Value.ToString().Trim();
                frm12.TextBox7.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[6].Value.ToString().Trim();
                frm12.TextBox11.Text = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[2].Value.ToString().Trim();

                this.Close();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            aktar();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
             baglanti();
             DataGridView1.Rows.Clear();
        OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI ORDER BY StokKodu ASC", bag);
        OleDbDataReader oku=cmd.ExecuteReader();
        
        while(oku.Read())
        {
            OleDbCommand a = new OleDbCommand("SELECT * From STOKGIRISCIKIS where StokKodu='" + oku[0].ToString() + "'", bag);
            OleDbDataReader b = a.ExecuteReader();
            if (b.HasRows)
            {
                b.Read();
                DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[4].ToString(), oku[11].ToString(), oku[12].ToString(), oku[8].ToString(), b[6].ToString());
            }
            else
            {
                DataGridView1.Rows.Add(oku[0].ToString(), oku[1].ToString(), oku[2].ToString(), oku[4].ToString(), oku[11].ToString(), oku[12].ToString(), oku[8].ToString());

            }
        }
        oku.Close();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            aktar();
        }
    }
}
