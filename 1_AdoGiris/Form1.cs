using System.Data;
using System.Data.SqlClient;
// using => kullan�lacak komutlar�n namespacleirni dahil eder...
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
            // SqlConnection => veritaban� ba�lant�s� yapmak i�in kullan�l�r....

            SqlConnection cnn = new SqlConnection();

            cnn.ConnectionString = "Server=localhost;Database=Northwind;uid=sa;pwd=123";

            cnn.Open(); // veritaban� ba�lant�s�n� a�...

            ConnectionState durum = cnn.State; // ba�lant�n�n durumu...

            cnn.Close(); // i� bitirildi�inde ba�lant� kapat�l�r..
            durum = cnn.State;

        }

        private void btnKategoriListesi_Click(object sender, EventArgs e)
        {   // ORM
            SqlConnection cnn = new SqlConnection("Server=localhost;Database=Northwind;uid=sa;pwd=123");
            //cnn.ConnectionString =""
            // SqlCommand => sql queryleri yazmak i�in kullan�l�r...
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CategoryName from Categories"; // sql querysidir...
            cmd.Connection = cnn; // query'nin connectini belirtilir...
            cnn.Open(); // ba�lant�y� a�
            // komutu �al��t�rmak...
            //cmd.ExecuteNonQuery(); // insert,update,delete i�in
            //cmd.ExecuteReader();  // tablo se�mek i�in
            //cmd.ExecuteScalar()  // function se�mek i�in
            SqlDataReader rdr = cmd.ExecuteReader();

            // rdr.Read(); // bir sat�r oku...
            while (rdr.Read())
            {
                string categoryName = (string)rdr["CategoryName"]; // Okunan sat�rdaki CategoryName alan�n� strine �evir ve ata...
                lstKategoriListesi.Items.Add(categoryName);
            }

            cnn.Close();  // ba�lant�y� kapat...
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