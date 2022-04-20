using System.Data;
using System.Data.SqlClient;
// using => kullanýlacak komutlarýn namespacleirni dahil eder...
namespace _1_AdoGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            // SqlConnection => veritabaný baðlantýsý yapmak için kullanýlýr....

            SqlConnection cnn = new SqlConnection();

            cnn.ConnectionString = "Server=localhost;Database=Northwind;uid=sa;pwd=123";

            cnn.Open(); // veritabaný baðlantýsýný aç...

            ConnectionState durum = cnn.State; // baðlantýnýn durumu...

            cnn.Close(); // iþ bitirildiðinde baðlantý kapatýlýr..
            durum = cnn.State;

        }

        private void btnKategoriListesi_Click(object sender, EventArgs e)
        {   // ORM
            SqlConnection cnn = new SqlConnection("Server=localhost;Database=Northwind;uid=sa;pwd=123");
            //cnn.ConnectionString =""
            // SqlCommand => sql queryleri yazmak için kullanýlýr...
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryName from Categories"; // sql querysidir...
            cmd.Connection = cnn; // query'nin connectini belirtilir...
            cnn.Open(); // baðlantýyý aç
            // komutu çalýþtýrmak...
            //cmd.ExecuteNonQuery(); // insert,update,delete için
            //cmd.ExecuteReader();  // tablo seçmek için
            //cmd.ExecuteScalar()  // function seçmek için
            SqlDataReader rdr = cmd.ExecuteReader();

            // rdr.Read(); // bir satýr oku...
            while (rdr.Read())
            {
                string categoryName = (string)rdr["CategoryName"]; // Okunan satýrdaki CategoryName alanýný strine çevir ve ata...
                lstKategoriListesi.Items.Add(categoryName);
            }

            cnn.Close();  // baðlantýyý kapat...
        }

        private void lstKategoriListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catName = lstKategoriListesi.SelectedItem.ToString();
            SqlConnection cnn = new SqlConnection("Server=localhost;Database=Northwind; uid=sa;pwd=123");

            SqlCommand cmd = new SqlCommand("select * from Categories where CategoryName=@Name", cnn);
            cmd.Parameters.AddWithValue("@Name", catName);
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            int CatId = (int)rdr["CategoryId"];
            cnn.Close();


            SqlCommand cmd2 = new SqlCommand("select count(*) from Products where CategoryId=@ID", cnn);
            cmd2.Parameters.AddWithValue("@ID", CatId);
            cnn.Open();

            int result =(int)cmd2.ExecuteScalar();
            lblUrunSayisi.Text = result.ToString();

            cnn.Close();
        }
    }
}