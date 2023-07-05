using AnilLab.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnilLab.Manager
{
    internal class SqlManager
    {
        SqlConnection con = new SqlConnection(@"Server = localhost\SQLEXPRESS; Database=Anil;Trusted_Connection=True;");

       public int SignIn(string tcno,string sifre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteri where tcno=@tcno",con);
            cmd.Parameters.AddWithValue("@tcno", tcno);
            SqlDataReader dataReader = cmd.ExecuteReader();
            bool isExist = false;
            string pass = "";
            int id = -1;
            while (dataReader.Read())
            {
                isExist = true;
                pass = dataReader["sifre"].ToString();
                 id = Convert.ToInt32(dataReader["id"]);
            }
            con.Close();

            if (isExist && pass== sifre)
            {
                return id;
            }
            else
            {
                return -1;
            }
        }

        public MusteriModel MusteriBilgiGetir(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteri where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
           MusteriModel musteri = new MusteriModel();
            while (dataReader.Read())
            {
               musteri.id = Convert.ToInt32(dataReader["id"]);
                musteri.adi = dataReader["adisoyadi"].ToString();
                musteri.tel= dataReader["telefon"].ToString() ;
                musteri.tc = dataReader["tcno"].ToString();
                musteri.sifre = dataReader["sifre"].ToString();
                musteri.eposta = dataReader["eposta"].ToString();
                musteri.adres = dataReader["adres"].ToString();
            }
            con.Close();
            return musteri;
           
        }

        public void MusteriBilgiGuncelle(int id,string telefon,string eposta,string adres,string sifre)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Musteri SET telefon=@telefon,eposta=@eposta,adres=@adres,sifre=@sifre WHERE id=@id; ", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@telefon", telefon);
            cmd.Parameters.AddWithValue("@eposta", eposta);
            cmd.Parameters.AddWithValue("@adres", adres);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public List<HesapModeli> HesaplariGetir(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Hesap where mID=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dataReader = cmd.ExecuteReader();
            List<HesapModeli> list = new List<HesapModeli>();
            while (dataReader.Read())
            {
                HesapModeli hesap = new HesapModeli();
                hesap.id = Convert.ToInt32(dataReader["id"]);
                hesap.mID= Convert.ToInt32(dataReader["mID"]);
               hesap.bakiye = Convert.ToInt32(dataReader["bakiye"]);
                list.Add(hesap);
                
            }
            con.Close();
            return list;

        }
        public void HesabiSil(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Hesap where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
           
        }
        public void HesapEkle(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Hesap(mID,bakiye) values(@id,0)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void HesapParaGuncelle(int id, int eklenecek)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Hesap SET bakiye=@bakiye WHERE id=@id; ", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@bakiye", eklenecek);
            cmd.ExecuteNonQuery();
            con.Close();

        }

    }
}
