using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-D2I68B45\SQLEXPRESS01;Initial Catalog=DbYTAKutuphane;Integrated Security=True");
        public FormKitaplar()
        {
            InitializeComponent();
        }

        

        private void buttonyenikitap_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar (KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxyazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", "True");
                sqlCommand.Parameters.AddWithValue("@P6", textBoxKitapTürKodu.Text);

                sqlCommand.ExecuteNonQuery();

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Kitap eklerken hata oluştu!"+ex.Message);
            }
            finally 
            {
                baglanti.Close();
            
            }
            verileriGoster();

        }

        private void verileriGoster() 
        {
            try 
            {

                string q = "SELECT * FROM TableKitaplar";
            SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewkitaplar.DataSource = dt;
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void dataGridViewkitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label8.Text = "0";
            int secilenSatir = dataGridViewkitaplar.SelectedCells[0].RowIndex;
            labelID.Text= dataGridViewkitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewkitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text= dataGridViewkitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxyazarSoyad.Text= dataGridViewkitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text= dataGridViewkitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTürKodu.Text= dataGridViewkitaplar.Rows[secilenSatir].Cells[8].Value.ToString();

            textBoxödünçalan.Text= dataGridViewkitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if(dataGridViewkitaplar.Rows[secilenSatir].Cells[7].Value !=DBNull.Value)
               dateTimePickerödünçalmatarih.Value= (DateTime) dataGridViewkitaplar.Rows[secilenSatir].Cells[7].Value;

        }

        private void buttonkitapbilgileri_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi = @P1,YazarAdi=@P2,YazarSoyadi=@P3,ISBN=@P4,KitapTurKodu=@P5 WHERE ID=@P6", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxyazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTürKodu.Text);

                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellerken hata oluştu!" + ex.Message);
            }
            finally
            {
                baglanti.Close();

            }
            verileriGoster();



        }

        private void buttonkitapödünçver_Click(object sender, EventArgs e)
        {
            if(labelID.Text!="-") 
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1,OduncAlmaTarihi=@P2,Durum=@P3 WHERE ID=@P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxödünçalan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerödünçalmatarih.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç işlemi sırasında hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();

                }
                verileriGoster();

            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçiniz !");
            }
        }

        private void buttongecikmebedeli_Click(object sender, EventArgs e)
        {
            if (labelID.Text!= "-")
            {
                DateTime bugununTarihi = DateTime.Now;
                int gunFarki =(int) (bugununTarihi - dateTimePickerödünçalmatarih.Value.Date).TotalDays;
                if (gunFarki>10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 1;
                    label8.Text=gecikmeBedeli.ToString();
                }
                
            }
        }

        private void buttonkitabıiadeet_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1,OduncAlmaTarihi=@P2,Durum=@P3 WHERE ID=@P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                    textBoxödünçalan.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç işlemi sırasında hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();

                }
                verileriGoster();

            }
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            metinKutularınıTemizle();

        }
        public void metinKutularınıTemizle() 
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxyazarSoyad.Text = "";
            textBoxISBN.Text = "";
            textBoxKitapTürKodu.Text = "";
            textBoxödünçalan.Text = "";


        }


        private void buttonara_Click(object sender, EventArgs e)
        {
            aramaSonuclariniGoster();
        }

        private void aramaSonuclariniGoster()
        {
            try
            {

                

                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxKitapAdi.Text
                                                                               + "%' AND YazarAdi LIKE '" + textBoxYazarAdi.Text + "%'"
                                                                               + " AND YazarSoyadi LIKE '" + textBoxyazarSoyad.Text + "%'"
                                                                               + " AND ISBN LIKE '" + textBoxISBN.Text + "%'"
                                                                               + " AND KitapTurKodu LIKE '" + textBoxKitapTürKodu.Text + "%'"
                                                                               + " AND OduncAlan LIKE '" + textBoxödünçalan.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewkitaplar.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttontümkitaplar_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen silinecek kitabı seçiniz ");

            }
            else
            {


                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID =@P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);


                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silinirken hata oluştu!" + ex.Message);
                }
                finally
                {
                    baglanti.Close();

                }
                verileriGoster();
                metinKutularınıTemizle();
            }
        }
    }
}
