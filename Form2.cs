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
            string islem = "giriş"; 
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
                DateTime now = DateTime.Now;
                string v = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
                
                MessageBox.Show("Tebrikler Giriş Başarılı!");
                dr.Close();
                string sorgu = " INSERT INTO log(time,islem,username) VALUES (@time,@islem,@username) ";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                
                komut.Parameters.AddWithValue("@time", v);
                komut.Parameters.AddWithValue("@islem", islem);
                komut.Parameters.AddWithValue("@username", user);
                komut.ExecuteNonQuery();

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
