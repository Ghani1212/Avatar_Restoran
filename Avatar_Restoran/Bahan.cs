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

    public partial class Bahan : Form
    {
        private string stringConnection = "data source=MAYLA;" + "database=restoran;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Bahan()
        {
            InitializeComponent();
        }

        private void Bahan_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
            LoadData();
        }

        public void ConnectToDatabase()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kodeBahan = textBox1.Text;
            string namaBahan = textBox2.Text;
            int stokBahan = int.Parse(textBox3.Text);

            using (SqlCommand command = new SqlCommand("UPDATE bahan SET nama_bahan = @namaBahan, stock_bahan = @stokBahan  WHERE kode_bahan = @kodeBahan", koneksi))
            {

                command.Parameters.AddWithValue("@kodeBahan", kodeBahan);
                command.Parameters.AddWithValue("@namaBahan", namaBahan);
                command.Parameters.AddWithValue("@stokBahan", stokBahan);

                command.ExecuteNonQuery();

                LoadData();
             }
        }
    


        private void button1_Click(object sender, EventArgs e)
        {
            string kodeBahan = textBox1.Text;
            string namaBahan = textBox2.Text;
            int stockBahan = int.Parse(textBox3.Text);

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to insert a new row into the "bahan" table
                string query = "INSERT INTO bahan (kode_bahan, nama_bahan, stock_bahan)" +
                               "VALUES (@kodeBahan, @namaBahan, @stokBahan)";

                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@kodeBahan", kodeBahan);
                    command.Parameters.AddWithValue("@namaBahan", namaBahan);
                    command.Parameters.AddWithValue("@stokBahan", stockBahan);

                    connection.Open();

                    command.ExecuteNonQuery();

                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            // Fill DataGridView with data from the "memesan" table
            string query = "SELECT * FROM bahan";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
