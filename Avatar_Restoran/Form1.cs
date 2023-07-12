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
        private string stringConnection = "data source=LAPTOP-3GHBBCII\\GHANIZUMAR;" + "database=restoran;User ID=sa;Password=ghani1211";
        private SqlConnection koneksi;
        public Form1()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customerpage = new Customer();
            customerpage.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chasierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chasier chasierpage = new Chasier();
            chasierpage.Show();
            this.Hide();
        }

        private void tableMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menupage = new Menu();
            menupage.Show();
            this.Hide();
        }

        private void kokiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bahan bahanpage = new Bahan();
            bahanpage.Show();
            this.Hide();
        }
    }
}
