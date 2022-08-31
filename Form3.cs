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
    public partial class Form3 : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlCommand komut1;
        MySqlDataReader dr;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel;uid=root;Pwd='pew6m7yw';");
            string sifread = textBox1.Text;
            string sifremail = textBox2.Text;
            string yenisifre = textBox3.Text;
            komut = new MySqlCommand();
            
            baglanti.Open();
            komut.Connection = baglanti;
            
            komut.CommandText = "Select*From kullanicilar where kullanici_ad='" + textBox1.Text +
                "'And kullanici_mail='" + textBox2.Text + "'";
            string sorgu = ""; 
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                sorgu = "UPDATE kullanicilar SET kullanici_sifre=@kullanici_sifre where kullanici_ad=@kullanici_ad";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kullanici_sifre", textBox3.Text);
                komut.Parameters.AddWithValue("@kullanici_ad", textBox1.Text);
                MessageBox.Show("Tebrikler İşlem Başarılı!");
                dr.Close();
                komut.ExecuteNonQuery();

                Form2 fr2 = new Form2();
                fr2.ShowDialog();
            }

            else

            {
                MessageBox.Show("Hatalı Bilgi Girdiniz!");

            }
            
            baglanti.Close();
        }
    }
}
