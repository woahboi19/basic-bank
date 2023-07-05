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
    public partial class Musteri : Form
    {
        public int id = -1;
        MusteriModel musteriBilgi = new MusteriModel();
        List<HesapModeli> hesaplar = new List<HesapModeli>(); 
        SqlManager manager = new SqlManager();
        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn yatirButon = new DataGridViewButtonColumn();
            yatirButon.HeaderText = "";
            yatirButon.Text = "Yatır";
            yatirButon.Name = "yatirButon";
            yatirButon.UseColumnTextForButtonValue = true;
            yatirButon.Width = 80;
            dgwHesaplar.Columns.Add(yatirButon); 
            DataGridViewButtonColumn cekButon = new DataGridViewButtonColumn();
            cekButon.HeaderText = "";
            cekButon.Text = "Çek";
            cekButon.Name = "cekButon";
            cekButon.UseColumnTextForButtonValue = true;
            cekButon.Width = 80;
            dgwHesaplar.Columns.Add(cekButon);
            DataGridViewButtonColumn silButon = new DataGridViewButtonColumn();
            silButon.HeaderText = "";
            silButon.Text = "Sil";
            silButon.Name = "silButon";
            silButon.UseColumnTextForButtonValue = true;
            silButon.Width = 80;
            dgwHesaplar.Columns.Add(silButon);


            musteriBilgi = manager.MusteriBilgiGetir(id);
            lblBilgi.Text =": "+ musteriBilgi.adi +"\r\n: "+musteriBilgi.tel + "\r\n: " +musteriBilgi.eposta + "\r\n: " +musteriBilgi.adres;

            hesaplar = manager.HesaplariGetir(id);

            dgwHesaplar.Rows.Clear();
            hesaplar.ForEach(hesap =>
            {
                dgwHesaplar.Rows.Add(hesap.id,hesap.bakiye);
            });
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            pnlGuncelleBilgi.Visible = true;
            tbTelefon.Text = musteriBilgi.tel;
            tbEposta.Text = musteriBilgi.eposta;
            tbAdres.Text = musteriBilgi.adres;
            tbSifre.Text = musteriBilgi.sifre;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            pnlGuncelleBilgi.Visible = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            manager.MusteriBilgiGuncelle(musteriBilgi.id,tbTelefon.Text,tbEposta.Text,tbAdres.Text,tbSifre.Text);
            pnlGuncelleBilgi.Visible = false;

            musteriBilgi = manager.MusteriBilgiGetir(id);
            lblBilgi.Text = ": " + musteriBilgi.adi + "\r\n: " + musteriBilgi.tel + "\r\n: " + musteriBilgi.eposta + "\r\n: " + musteriBilgi.adres;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2)
            {
                int hesapIDY = Convert.ToInt32(dgwHesaplar.CurrentRow.Cells[0].Value);
                HesapModeli hesapY = hesaplar.Where(hesap => hesap.id == hesapIDY).FirstOrDefault();
                ParaYatir py = new ParaYatir();
                py.hesap = hesapY;
                py.Show();
            }
            else if(e.ColumnIndex == 3)
            {
                int hesapIDC = Convert.ToInt32(dgwHesaplar.CurrentRow.Cells[0].Value);
                HesapModeli hesapC = hesaplar.Where(hesap => hesap.id == hesapIDC).FirstOrDefault();
                ParaCek pc = new ParaCek();
                pc.hesap = hesapC;
                pc.Show();

            }
            else if(e.ColumnIndex == 4)
            {
                int hesapIDS = Convert.ToInt32(dgwHesaplar.CurrentRow.Cells[0].Value);
                HesapModeli hesapS =hesaplar.Where(hesap => hesap.id == hesapIDS).FirstOrDefault();
                if (hesapS.bakiye != 0)
                {
                    MessageBox.Show("Hesabı silebilmek için bakiyenin 0 TL olması gerekmektedir.");
                }
                else
                {
                    DialogResult res = MessageBox.Show("Hesap silinecek. Onaylıyor musunuz ? ", "Hesap Silinecek", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {

                        manager.HesabiSil(hesapS.id);

                        MessageBox.Show("Hesap Silinmiştir.");
                        hesaplar.Clear();
                        hesaplar = manager.HesaplariGetir(id);

                        dgwHesaplar.Rows.Clear();
                        hesaplar.ForEach(hesap =>
                        {
                            dgwHesaplar.Rows.Add(hesap.id, hesap.bakiye);
                        });

                    }
                    if (res == DialogResult.Cancel)
                    {

                    }
                }

               
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            hesaplar.Clear();
            hesaplar = manager.HesaplariGetir(id);
            dgwHesaplar.Rows.Clear();
            hesaplar.ForEach(hesap =>
            {
                dgwHesaplar.Rows.Add(hesap.id, hesap.bakiye);
            });
        }

        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            manager.HesapEkle(id);

            hesaplar.Clear();
            hesaplar = manager.HesaplariGetir(id);
            dgwHesaplar.Rows.Clear();
            hesaplar.ForEach(hesap =>
            {
                dgwHesaplar.Rows.Add(hesap.id, hesap.bakiye);
            });
        

    }

    }
}
