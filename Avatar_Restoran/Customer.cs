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
        private string stringConnection = "data source=LAPTOP-3GHBBCII\\GHANIZUMAR;" + "database=restoran;User ID=sa;Password=ghani1211";
        private SqlConnection koneksi;
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();

        }


        public void ConnectToDatabase()
        {
            koneksi = new SqlConnection(stringConnection);
            koneksi.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Get the values from the TextBox controls and DateTimePicker control
            string kodePemesanan = txtKodePemesanan.Text;
            string kodeMenu = txtKodeMenu.Text;
            int jumlahPemesanan = int.Parse(txtJumlahPemesanan.Text);
            int idPelanggan = int.Parse(txtIdPelanggan.Text);
            DateTime tglPemesanan = dateTimePicker.Value;
            decimal harga = decimal.Parse(txtHarga.Text);

            // Establish a database connection
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to insert a new row into the "memesan" table
                string query = "INSERT INTO memesan (kode_pemesanan, kode_menu, jumlah_pesanan, id_pelanggan, tgl_pemesanan, harga) " +
                               "VALUES (@kodePemesanan, @kodeMenu, @jumlahPesanan, @idPelanggan, @tglPemesanan, @harga)";
                SqlCommand command = new SqlCommand(query, koneksi);

                // Add parameters to the command
                command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);
                command.Parameters.AddWithValue("@kodeMenu", kodeMenu);
                command.Parameters.AddWithValue("@jumlahPesanan", jumlahPemesanan);
                command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                command.Parameters.AddWithValue("@tglPemesanan", tglPemesanan);
                command.Parameters.AddWithValue("@harga", harga);

                // Open the connection
                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();

                // Refresh the DataGridView to show the new data
                dataGridView.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from the TextBox controls and DateTimePicker control
            string kodePemesanan = txtKodePemesanan.Text;
            string kodeMenu = txtKodeMenu.Text;
            int jumlahPemesanan = int.Parse(txtJumlahPemesanan.Text);
            int idPelanggan = int.Parse(txtIdPelanggan.Text);
            DateTime tglPemesanan = dateTimePicker.Value;
            decimal harga = decimal.Parse(txtHarga.Text);

            // Get the selected row from the DataGridView
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            int rowIndex = selectedRow.Index;

            // Get the kode_pemesanan value of the selected row
            string selectedKodePemesanan = selectedRow.Cells["kode_pemesanan"].Value.ToString();

            // Establish a database connection
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                // Create a SQL command to update the selected row in the "memesan" table
                string query = "UPDATE memesan SET kode_pemesanan = @kodePemesanan, kode_menu = @kodeMenu, " +
                               "jumlah_pemesanan = @jumlahPemesanan, id_pelanggan = @idPelanggan, " +
                               "tgl_pemesanan = @tglPemesanan, harga = @harga " +
                               "WHERE kode_pemesanan = @selectedKodePemesanan";
                SqlCommand command = new SqlCommand(query, koneksi);

                // Add parameters to the command
                command.Parameters.AddWithValue("@kodePemesanan", kodePemesanan);
                command.Parameters.AddWithValue("@kodeMenu", kodeMenu);
                command.Parameters.AddWithValue("@jumlahPemesanan", jumlahPemesanan);
                command.Parameters.AddWithValue("@idPelanggan", idPelanggan);
                command.Parameters.AddWithValue("@tglPemesanan", tglPemesanan);
                command.Parameters.AddWithValue("@harga", harga);
                command.Parameters.AddWithValue("@selectedKodePemesanan", selectedKodePemesanan);

                // Open the connection
                connection.Open();

                // Execute the command
                command.ExecuteNonQuery();

                // Update the corresponding row in the DataGridView with the modified values
                DataGridViewRow row = dataGridView.Rows[rowIndex];
                row.Cells["kode_pemesanan"].Value = kodePemesanan;
                row.Cells["kode_menu"].Value = kodeMenu;
                row.Cells["jumlah_pemesanan"].Value = jumlahPemesanan;
                row.Cells["id_pelanggan"].Value = idPelanggan;
                row.Cells["tgl_pemesanan"].Value = tglPemesanan;
                row.Cells["harga"].Value = harga;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Get the selected row from the DataGridView
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Get the kode_pemesanan value of the selected row
                string selectedKodePemesanan = selectedRow.Cells["kode_pemesanan"].Value.ToString();

                // Establish a database connection
                using (SqlConnection connection = new SqlConnection(stringConnection))
                {
                    // Create a SQL command to delete the selected row from the "memesan" table
                    string query = "DELETE FROM memesan WHERE kode_pemesanan = @selectedKodePemesanan";
                    SqlCommand command = new SqlCommand(query, koneksi);

                    // Add parameter to the command
                    command.Parameters.AddWithValue("@selectedKodePemesanan", selectedKodePemesanan);

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    command.ExecuteNonQuery();

                    // Remove the selected row from the DataGridView
                    dataGridView.Rows.Remove(selectedRow);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected row from the DataGridView
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

            // Get the values from the selected row
            string kodePemesanan = selectedRow.Cells["kode_pemesanan"].Value.ToString();
            string kodeMenu = selectedRow.Cells["kode_menu"].Value.ToString();
            int jumlahPemesanan = int.Parse(selectedRow.Cells["jumlah_pemesanan"].Value.ToString());
            int idPelanggan = int.Parse(selectedRow.Cells["id_pelanggan"].Value.ToString());
            DateTime tglPemesanan = DateTime.Parse(selectedRow.Cells["tgl_pemesanan"].Value.ToString());
            decimal harga = decimal.Parse(selectedRow.Cells["harga"].Value.ToString());

            // Populate the TextBox controls and DateTimePicker control with the values
            txtKodePemesanan.Text = kodePemesanan;
            txtKodeMenu.Text = kodeMenu;
            txtJumlahPemesanan.Text = jumlahPemesanan.ToString();
            txtIdPelanggan.Text = idPelanggan.ToString();
            dateTimePicker.Value = tglPemesanan;
            txtHarga.Text = harga.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
