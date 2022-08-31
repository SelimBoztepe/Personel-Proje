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
    public partial class Form2 : Form
    {
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=personel;uid=root;Pwd='pew6m7yw';");
            string user = txtGirisAd.Text;
            string password = txtGirisSifre.Text;
            komut = new MySqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select*From kullanicilar where kullanici_ad='" + txtGirisAd.Text +
                "'And kullanici_sifre='" + txtGirisSifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı!");
                Form1 fr1 = new Form1();
                fr1.ShowDialog();
            }
                    
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre!");

            }
            
            baglanti.Close();



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
            

        }
    }
}
