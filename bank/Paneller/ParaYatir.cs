using AnilLab.Manager;
using AnilLab.Model;
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
    public partial class ParaYatir : Form
    {
        public HesapModeli hesap = new HesapModeli();
        SqlManager manager = new SqlManager();
        public ParaYatir()
        {
            InitializeComponent();
        }

        private void ParaYatir_Load(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            int hesapBakiye = hesap.bakiye + Convert.ToInt32(tbPara.Text);
            manager.HesapParaGuncelle(hesap.id,hesapBakiye);
            this.Close();
        }

       
    }
}
