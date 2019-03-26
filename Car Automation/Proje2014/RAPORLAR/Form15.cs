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
using excel = Microsoft.Office.Interop.Excel;
namespace Proje2014
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        OleDbConnection bag;
        public void baglanti() {
            bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=STOKTAKIP.mdb");
            bag.Open();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            baglanti();
            Form4 frm4=(Form4)Application.OpenForms["Form4"];
            if (frm4.kritik == true)
            {
                frm4.kritik = false;
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI,STOKGIRISCIKIS,BARKOD Where STOKKARTI.StokKodu=STOKGIRISCIKIS.StokKodu and STOKKARTI.StokKodu=BARKOD.StokKodu and GirisMik<'25'", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku["BarkodNo"], oku[2].ToString(), oku["Sinifi"], oku["Grubu"], oku["Tutari"], oku["GirisMik"]);
                }

            }
            else {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM STOKKARTI,STOKGIRISCIKIS,BARKOD Where STOKKARTI.StokKodu=STOKGIRISCIKIS.StokKodu and STOKKARTI.StokKodu=BARKOD.StokKodu", bag);
                OleDbDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    DataGridView1.Rows.Add(oku[0].ToString(), oku["BarkodNo"], oku[2].ToString(), oku["Sinifi"], oku["Grubu"], oku["Tutari"], oku["GirisMik"]);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();

            uygulama.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);

            Microsoft.Office.Interop.Excel.Worksheet sayfa1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            
            for (int j = 0; j < DataGridView1.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[1, 2 + j];

                myRange.Value2 = DataGridView1.Columns[j].HeaderText;

            }
            for (int i = 0; i <= DataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j <= 7; j++)
                {   
                    char[] dizi={'.',','};
                    string para = DataGridView1[i, 5].Value.ToString().Trim(dizi);
                    if (j == 5)
                    {
                        Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i + 2, j + 2];
                        alan.Value2 =para;
                        continue;
                    }
                    else
                    {
                        Microsoft.Office.Interop.Excel.Range alan = (Microsoft.Office.Interop.Excel.Range)sayfa1.Cells[i + 2, j + 2];
                        alan.Value2 = DataGridView1[j, i].Value == null ? "" : DataGridView1[j, i].Value;
                    }
                }
            }
        }
    }
}
