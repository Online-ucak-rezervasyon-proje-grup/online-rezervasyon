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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection k_baglan = new OleDbConnection ("Provider = Microsoft.ACE.Oledb.12.0; Data Source = genelvt.accdb");
            k_baglan.Open();
            OleDbCommand komut= new OleDbCommand ("insert into kullanici (adi, soyadi, tc_no, kullanici_adi, sifre) values(@adi, @soyadi, @tc_no, @kullanici_adi, @sifre)", k_baglan);
            komut.Parameters.AddWithValue("@adi", textBox1.Text);
            komut.Parameters.AddWithValue("@soyadı", textBox2.Text);
            komut.Parameters.AddWithValue("@tc_no", textBox3.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", textBox4.Text);
            komut.Parameters.AddWithValue("@sifre", textBox5.Text);                       
            komut.ExecuteNonQuery();
            k_baglan.Close();
            MessageBox.Show("Kayıt işleminiz başarıyla tamamlanmıştır.");
        }

        private void kayitol_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}