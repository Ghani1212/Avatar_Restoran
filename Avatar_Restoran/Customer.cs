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

namespace Avatar_Restoran
{
    public partial class Customer : Form
    {
        private string stringConnection = "data source=MAYLA;" + "database=restoran;User ID=sa;Password=123";
        private SqlConnection koneksi;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
            LoadData();
        }

        public void ConnectToDatabase()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
        }

        private void LoadData()
        {
            // Fill DataGridView with data from the "memesan" table
            string query = "SELECT * FROM memesan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string kodePemesanan = textBox1.Text;
            string kodeMenu = comboBox3.Text;
            int jumlahPesanan = int.Parse(txtJumlahPemesanan.Text);
            string idPelanggan = comboBox1.Text;
            DateTime tglPemesanan = dateTimePicker.Value;
            decimal harga = decimal.Parse(txtHarga.Text);

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to insert a new row into the "memesan" table
                string query = "INSERT INTO memesan (kode_pemesanan, kode_menu, jumlah_pesanan, id_pelanggan, tgl_pemesanan, harga) " +
                               "VALUES (@kodePemesanan, @kodeMenu, @jumlahPesanan, @idPelanggan, @tglPemesanan, @harga)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);
                command.Parameters.AddWithValue("@kodeMenu", kodeMenu);
                command.Parameters.AddWithValue("@jumlahPesanan", jumlahPesanan);
                command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                command.Parameters.AddWithValue("@tglPemesanan", tglPemesanan);
                command.Parameters.AddWithValue("@harga", harga);

                // Open the connection
                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();

                // Refresh the DataGridView to show the new data
                LoadData();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kodePemesanan = textBox1.Text;
            string kodeMenu = comboBox3.Text;
            int jumlahPesanan = int.Parse(txtJumlahPemesanan.Text);
            string idPelanggan = comboBox1.Text;
            DateTime tglPemesanan = dateTimePicker.Value;
            decimal harga = decimal.Parse(txtHarga.Text);

            using (SqlCommand command = new SqlCommand("UPDATE memesan SET kode_pemesanan = @kodePemesanan, kode_menu = @kodeMenu, jumlah_pesanan = @jumlahPesanan, id_pelanggan = @idPelanggan, tgl_pemesanan = @tglPemesanan, harga = @harga", koneksi))
            {
                command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);
                command.Parameters.AddWithValue("@kodeMenu", kodeMenu);
                command.Parameters.AddWithValue("@jumlahPesanan", jumlahPesanan);
                command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                command.Parameters.AddWithValue("@tglPemesanan", tglPemesanan);
                command.Parameters.AddWithValue("@harga", harga);

                command.ExecuteNonQuery();

                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kodePemesanan = textBox1.Text;

            using (SqlCommand command = new SqlCommand("DELETE FROM memesan WHERE kode_pemesanan = @kodePemesanan", koneksi))
            {
                command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);

                command.ExecuteNonQuery();

                LoadData();
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}