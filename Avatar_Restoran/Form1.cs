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
    public partial class Form1 : Form
    {
        private string stringConnection = "data source=MAYLA;" + "database=restoran;User ID=sa;Password=123";
        private SqlConnection koneksi;
        public Form1()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buka Form Customer saat tombol Customer ditekan
            Customer customerForm = new Customer();
            customerForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void chasierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buka Form Cashier saat tombol Cashier ditekan
            Chasier cashierForm = new Chasier();
            cashierForm.Show();
        }

        private void tableMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buka Form Menu saat tombol Menu ditekan
            Menu menuForm = new Menu();
            menuForm.Show();
        }

        private void BahanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buka Form Bahan saat tombol Bahan ditekan
            Bahan bahanForm = new Bahan();
            bahanForm.Show();
        }

        private void kokiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Buka Form Bahan saat tombol Bahan ditekan
            Bahan bahanForm = new Bahan();
            bahanForm.Show();
        }
    }
}
