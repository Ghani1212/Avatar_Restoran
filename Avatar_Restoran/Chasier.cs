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
    public partial class Chasier : Form
    {
        private string stringConnection = "data source=MAYLA;" + "database=restoran;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Chasier()
        {
            InitializeComponent();
        }

        public void ConnectToDatabase()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
        }

        private void LoadData()
        {
            // Fill DataGridView with data from the "memesan" table
            string query = "SELECT * FROM melayani";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Chasier_Load(object sender, EventArgs e)
        {
            
            ConnectToDatabase();
            LoadData();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idPelanggan = textBox4.Text;
            string idKasir = textBox2.Text;
            string kodePemesanan = textBox3.Text;
            decimal harga = decimal.Parse(textBox1.Text);

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to insert a new row into the "melayani" table
                string query = "INSERT INTO melayani (id_kasir, id_pelanggan, kode_pemesanan, harga) " +
                               "VALUES (@idKasir, @idPelanggan, @kodePemesanan, @harga)";

                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@idKasir", idKasir);
                    command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                    command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);
                    command.Parameters.AddWithValue("@harga", harga);

                    connection.Open();

                    command.ExecuteNonQuery();

                    LoadData();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string idPelanggan = textBox4.Text;
            string idKasir = textBox2.Text;
            string kodePemesanan = textBox3.Text;
            decimal harga = decimal.Parse(textBox1.Text);

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to insert a new row into the "melayani" table
                string query = "INSERT INTO melayani (id_kasir, id_pelanggan, kode_pemesanan, harga)" +
                               "VALUES (@idKasir, @idPelanggan, @kodePemesanan, @harga)";

                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@idKasir", idKasir);
                    command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                    command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);
                    command.Parameters.AddWithValue("@harga", harga);

                    connection.Open();

                    command.ExecuteNonQuery();

                    LoadData();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idKasir = textBox2.Text;

            using (SqlCommand command = new SqlCommand("DELETE FROM melayani WHERE id_kasir = @idKasir", koneksi))
            {
                command.Parameters.AddWithValue("@idKasir", idKasir );

                command.ExecuteNonQuery();

                LoadData();
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
