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
    public partial class giris_panel : Form
    {
        public giris_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris f4 = new Giris();
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            admin_giris f5 = new admin_giris();
            f5.Show();
        }
    }
}