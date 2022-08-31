using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace personelkayit
{
    public partial class Form1 : Form
    {
       MySqlConnection baglanti;
       MySqlCommand komut;
       MySqlDataAdapter da;


        public Form1()
        {
            InitializeComponent();
        }

        void KullaniciListele()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel;uid=root;Pwd='pew6m7yw';");
            baglanti.Open();
            string komut = "select * from kullanicilar";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
            {
                KullaniciListele();
            }

            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNumara.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel;uid=root;Pwd='pew6m7yw';");
            string sorgu = " INSERT INTO kullanicilar(kullanici_no,kullanici_ad,kullanici_soyad,kullanici_sifre,kullanici_mail) VALUES (@kullanici_no,@kullanici_ad,@kullanici_soyad,@kullanici_sifre,@kullanici_mail) ";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullanici_no", txtNumara.Text);
            komut.Parameters.AddWithValue("@kullanici_ad", txtAd.Text);
            komut.Parameters.AddWithValue("@kullanici_soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@kullanici_sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@kullanici_mail", txtMail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KullaniciListele();
            


        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel;uid=root;Pwd='pew6m7yw';");
            string sorgu = "DELETE FROM kullanicilar WHERE kullanici_no=@kullanici_no";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullanici_no", txtNumara.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KullaniciListele();
        }

        private void btnGüncelleme_Click(object sender, EventArgs e)
        {
            DataGridViewCell kullanici_no = dataGridView1.CurrentRow.Cells[0];
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel;uid=root;Pwd='pew6m7yw';");
            string sorgu = "UPDATE kullanicilar SET kullanici_ad=@kullanici_ad,kullanici_soyad=@kullanici_soyad,kullanici_sifre=@kullanici_sifre,kullanici_mail=@kullanici_mail WHERE kullanici_no=@kullanici_no";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullanici_no", txtNumara.Text);
            komut.Parameters.AddWithValue("@kullanici_ad", txtAd.Text);
            komut.Parameters.AddWithValue("@kullanici_soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@kullanici_sifre", txtSifre.Text);
            komut.Parameters.AddWithValue("@kullanici_mail", txtMail.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KullaniciListele();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
