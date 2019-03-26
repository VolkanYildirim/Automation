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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Form1 f = (Form1)Application.OpenForms["Form1"];
            string sifre = f.sifre;
            if (textBox1.Text != sifre)
                MessageBox.Show("Şifre Hatalı!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                timer1.Enabled = true;
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.IndianRed;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightGreen;
        }

    }
}
