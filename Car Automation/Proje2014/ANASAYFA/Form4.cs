using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       public int f;
       public bool kritik=false;
       
        public void cikis()
        {
            DialogResult a = MessageBox.Show("Çıkmak İstediğinizden Emin Misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            cikis();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = 10;
            Timer2.Enabled = true;

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cikis();
        }

        private void ekranıKilitleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f = 4;
            Timer2.Enabled = true;


        }

        private void yeniStokKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = 1;
            Timer2.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = 1;
            Timer2.Enabled = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        Timer1.Enabled = true;
        Timer2.Enabled = false;
        toolStripStatusLabel2.Text = "Ahmet ÇATALKAYA 121180024";
        toolStripStatusLabel3.Text = "Volkan YILDIRIM 131180506";
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        this.Text = "Honda Yetkili Servis Randevu Kayıt ve Takip Sistemi Bayi Adı:" + frm1.ad;
        }

        private void stokGezginiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = 8;
            Timer2.Enabled = true;

        }

        private void yeniStokHareketiGirişToolStripMenuItem_Click(object sender, EventArgs e)
        {
         f = 2;
        Timer2.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value += 1;
            if (toolStripProgressBar1.Value >= 100)
            {
                Timer2.Enabled = false;
                if (f == 1)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm16 = new Form16();
                    frm16.ShowDialog();
                    return;
                }
                if (f == 2)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm10 = new Form10();
                    frm10.ShowDialog();
                    return;
                }
                if (f == 3)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm12 = new Form12();
                    frm12.ShowDialog();
                    return;
                }
                if (f == 4)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    this.WindowState = FormWindowState.Maximized;
                    Form frm5 = new Form5();
                    frm5.ShowDialog();
                }
                if (f == 5)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm7 = new Form7();
                    frm7.ShowDialog();
                    return;
                }
                if (f == 6)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm8 = new Form8();
                    frm8.ShowDialog();
                    return;
                }
                if (f == 7)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm9 = new Form9();
                    frm9.ShowDialog();
                    return;
                }
                if (f == 8)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm13 = new Form13();
                    frm13.ShowDialog();
                    return;
                }
                if (f == 10)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
                    toolStripProgressBar1.Value = 0;
                    Form frm6 = new Form6();
                    frm6.ShowDialog();
                    return;
                }
            
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void yeniStokHareketiÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
        f = 3;
        Timer2.Enabled = true;
        }

        private void birimTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        f = 5;
        Timer2.Enabled = true;

        }

        private void sınıfTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = 6;
            Timer2.Enabled = true;
        }

        private void grupTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = 7;
            Timer2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kritik = false;
            f = 11;
            Timer2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kritik = true;
            f = 11;
            Timer2.Enabled = true;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
