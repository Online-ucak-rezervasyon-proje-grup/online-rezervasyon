using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullanici_girisi
{
    public partial class odeme_ekranı : Form
    {
        public odeme_ekranı()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            labelAdSoyad.Text = textBox1.Text;
        }

        private void maskedTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            labelKartNo.Text = maskedTextBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSKT.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSKT.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void maskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            labelCVV.Text = maskedTextBox2.Text;
        }

        private void odeme_ekranı_Load(object sender, EventArgs e)
        {
            int ay;
            int yil;
            for (ay = 1; ay < 13; ay++)
            {
                comboBox1.Items.Add(ay);
            }
            for (yil = 21; yil <= 30; yil++)
            {
                comboBox2.Items.Add(yil);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödemeniz Başarıyla Tamamlanmıştır");
        }
    }
}
