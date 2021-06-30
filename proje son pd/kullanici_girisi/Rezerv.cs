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
    public partial class Rezerv : Form
    {
        public Rezerv()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=genelvt.accdb");
        private void ucus_goruntule()
        {
            listView1.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            //komut.CommandText = "SELECT havayolu,kalkis_tarihi,kalkis_yeri,varis_yeri,ucret FROM ucus WHERE  kalkis_tarihi=@kalkis_tarihi and kalkis_yeri=@kalkis_yeri and varis_yeri=@varis_yeri and havayolu=@havayolu ";
            komut.CommandText = "Select * From ucus";
            //komut.Parameters.AddWithValue("@kalkis_tarihi", dateTimePicker1.Value.ToString());
            //selectdatatimepicker
            OleDbDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                ListViewItem rez = new ListViewItem();
                rez.Text = okuyucu["havayolu"].ToString();
                rez.SubItems.Add(okuyucu["kalkis_tarihi"].ToString());
                rez.SubItems.Add(okuyucu["kalkis_yeri"].ToString());
                rez.SubItems.Add(okuyucu["varis_yeri"].ToString());
                rez.SubItems.Add(okuyucu["ucret"].ToString());

                listView1.Items.Add(rez);
            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ucus_goruntule();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            odeme_ekranı f10 = new odeme_ekranı();
            f10.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "1";            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "4";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "6";           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8";    
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "10";    
        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "11";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "12";          
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "13";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "14";            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "15";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "16";            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "17";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "18";     
        }      
    }
}