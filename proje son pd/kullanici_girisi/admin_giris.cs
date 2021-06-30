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

namespace kullanici_girisi
{
    public partial class admin_giris : Form
    {
        public admin_giris()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader okuyucu;
        private void button1_Click(object sender, EventArgs e)
        {

            string ad = admin_adi.Text;
            string sifre = admin_parola.Text;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=genelvt.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            komut.CommandText = "Select * from admin where StrComp(k_adi,'" + admin_adi.Text + "',0)=0 and StrComp(sifre,'" + admin_parola.Text + "',0)=0";
            okuyucu = komut.ExecuteReader();

            if (okuyucu.Read())
            {
                Admin f7 = new Admin();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Admin kullanıcı adı ve parolanızı lütfen doğru giriniz.");
            }

            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}