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
    public partial class Menu : Form
    {
        private string stringConnection = "data source=MAYLA;" + "database=restoran;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
            LoadData();
        }

        public void ConnectToDatabase()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kodeMenu = textBox1.Text;
            string namaMenu = textBox2.Text;
            int stokMenu = int.Parse(textBox3.Text);
            decimal hargaMenu = decimal.Parse(textBox4.Text);

            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to insert a new row into the "menu" table
                string query = "INSERT INTO menu (kode_menu, nama_menu, stok_menu, harga_menu) " +
                               "VALUES (@kodeMenu, @namaMenu, @stockMenu, @harga)";

                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@kodeMenu", kodeMenu);
                    command.Parameters.AddWithValue("@namaMenu", namaMenu);
                    command.Parameters.AddWithValue("@stockMenu", stokMenu);
                    command.Parameters.AddWithValue("@harga", hargaMenu);

                    connection.Open();

                    command.ExecuteNonQuery();

                    LoadData();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kodeMenu = textBox1.Text;

            using (SqlCommand command = new SqlCommand("DELETE FROM menu WHERE kode_menu = @kodeMenu", koneksi))
            {
                command.Parameters.AddWithValue("@kodeMenu", kodeMenu);

                command.ExecuteNonQuery();

                LoadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kodeMenu = textBox1.Text;
            string namaMenu = textBox2.Text;
            int stokMenu = int.Parse(textBox3.Text);
            decimal hargaMenu = decimal.Parse(textBox4.Text);

            using (SqlCommand command = new SqlCommand("UPDATE menu SET nama_menu = @namaMenu, stok_menu = @stockMenu, harga_menu = @harga WHERE kode_menu = @kodeMenu", koneksi))
            {
                command.Parameters.AddWithValue("@namaMenu", namaMenu);
                command.Parameters.AddWithValue("@stockMenu", stokMenu);
                command.Parameters.AddWithValue("@harga", hargaMenu);
                command.Parameters.AddWithValue("@kodeMenu", kodeMenu);

                command.ExecuteNonQuery();

                LoadData();
            }
        }

        private void LoadData()
        {
            // Fill DataGridView with data from the "memesan" table
            string query = "SELECT * FROM menu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
