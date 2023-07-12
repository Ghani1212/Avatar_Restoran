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
        private string stringConnection = "data source=LAPTOP-3GHBBCII\\GHANIZUMAR;" + "database=restoran;User ID=sa;Password=ghani1211";
        private SqlConnection koneksi;
        public Bahan()
        {
            InitializeComponent();
        }

        private void Bahan_Load(object sender, EventArgs e)
        {

        }
    }
}
