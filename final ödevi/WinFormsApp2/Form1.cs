using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        FormKitaplar formKitaplar;
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-D2I68B45\SQLEXPRESS01;Initial Catalog=DbYTAKutuphane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre="";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi=@p1",baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxkullaniciadi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while(sqlDataReader.Read()) 
                {
                    sifre = sqlDataReader[0].ToString();
                
                }
                //label3.Text = sifre;
                if (sifre==textBoxsifre.Text)
                {
                    
                    formKitaplar = new FormKitaplar();
                    formKitaplar.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý");
                    textBoxkullaniciadi.Text = "";
                    textBoxsifre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("baðlantý hatasý!"+ex.Message);
                
            }
            finally 
            { 
                baglanti.Close();  
            
            }
        }
    }
}