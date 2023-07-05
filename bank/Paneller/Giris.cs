using AnilLab.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnilLab.Paneller
{
    public partial class Giris : Form
    {
        SqlManager manager = new SqlManager();
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kAdi = tbTCNo.Text;
            string sifre = tbSifre.Text;
            int result = manager.SignIn(kAdi, sifre);
            if (result!=-1)
            {
               Musteri panel = new Musteri();
                panel.id = result;
                panel.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Başarisiz");
            }

        }
    }
}
