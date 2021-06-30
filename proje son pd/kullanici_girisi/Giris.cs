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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader okuyucu;
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = t_k_adi.Text;
            string sifre = t_parola.Text;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=genelvt.accdb");
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;

            komut.CommandText = "Select * from kullanici where StrComp(kullanici_adi,'" + t_k_adi.Text + "',0)=0 and StrComp(sifre,'" + t_parola.Text + "',0)=0";
            okuyucu = komut.ExecuteReader();
            
            if (okuyucu.Read())
            {
                Rezerv f2 = new Rezerv();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı veya parolanızı yanlış girdiniz lütfen tekrar deneyiniz. Kaydınız yoksa kayıt olunuz!!!");
            }

            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayitol f3 = new kayitol();
            f3.Show();
        }
    }
}