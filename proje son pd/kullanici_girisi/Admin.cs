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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=genelvt.accdb");
              
        private void kisi_goruntule()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From kullanici";
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = okuyucu["adi"].ToString();              
                ekle.SubItems.Add(okuyucu["soyadi"].ToString());
                ekle.SubItems.Add(okuyucu["tc_no"].ToString());
                ekle.SubItems.Add(okuyucu["kullanici_adi"].ToString());               

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kisi_goruntule();
        }
    }
}
